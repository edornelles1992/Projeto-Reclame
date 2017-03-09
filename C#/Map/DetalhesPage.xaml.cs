using Map.Classes;
using Map.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Streams;
using Windows.UI.Core;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Maps;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Map
{
    public sealed partial class DetalhesPage : Page
    {
        public DetalhesPageViewModel ViewModel { get; set; }

        public DetalhesPage()
        {
            this.InitializeComponent();
            this.ViewModel = new DetalhesPageViewModel();
            
        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {

            base.OnNavigatedTo(e);
            if (e.Parameter != null)
            {
                int codigo = Convert.ToInt32(e.Parameter);
                App minhaApp = (App)App.Current;
                var reclamacaoView = (from f in minhaApp.ReclamacaoFontesDados.reclamacao
                                      where f.IdReclamacao == codigo
                                      select f).FirstOrDefault();
                this.ViewModel.ReclamacaoAtual = reclamacaoView;
                this.ViewModel.ReclamacaoTemporario = new Reclamacao()
                {
                    IdReclamacao = reclamacaoView.IdReclamacao,
                    Bairro = reclamacaoView.Bairro,
                    Desc = reclamacaoView.Desc,
                    Titulo = reclamacaoView.Titulo
                                                                        ,
                    Data = reclamacaoView.Data,
                    Endereco = reclamacaoView.Endereco,
                    Categoria = reclamacaoView.Categoria,
                    Status = reclamacaoView.Status,
                    longitude = reclamacaoView.longitude,
                    latitude = reclamacaoView.latitude
                ,
                    foto = reclamacaoView.foto
                };

                string status;
                checkBoxResolvido.IsChecked = ViewModel.ReclamacaoTemporario.Status;
                if (ViewModel.ReclamacaoTemporario.Status == false)
                {
                    status = "ms-appx:///Assets/MapPin.png";

                }
                else
                {
                    status = "ms-appx:///Assets/marcador_resolvido.png";


                }

                //checkBoxResolvido.IsChecked = reclamacaoView.Status;
                BasicGeoposition snPosition = new BasicGeoposition() { Latitude = reclamacaoView.latitude, Longitude = reclamacaoView.longitude };
                Geopoint snPoint = new Geopoint(snPosition);

                MapIcon mapIcon = new MapIcon();
                mapIcon.Location = snPoint;
                mapIcon.NormalizedAnchorPoint = new Point(0.5, 1.0);
                mapIcon.Image = RandomAccessStreamReference.CreateFromUri(new Uri(status));
                mapIcon.ZIndex = 0;
                MapDetalhes.MapElements.Add(mapIcon);
                // int aux = MapDetalhes.MapElements.Count;
                // LocalClicado.Text = aux.ToString();
                MapDetalhes.Center = snPoint;
                MapDetalhes.ZoomLevel = 16;

                if (ViewModel.ReclamacaoTemporario.foto != null)
                {
                    textBlockImg.Text = "";
                    string nome = ViewModel.ReclamacaoTemporario.foto;
                    var localFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
                    StorageFile photoFile = await localFolder.GetFileAsync(nome);
                    IRandomAccessStream fileStream1 = await photoFile.OpenAsync(Windows.Storage.FileAccessMode.Read);

                    BitmapImage bitmapImage = new BitmapImage();


                    await bitmapImage.SetSourceAsync(fileStream1);
                    image.Source = bitmapImage;

                }
                else {
                    textBlockImg.Text = "Sem foto disponivel!";
                }
            }
        }

        private async void btSalvar_Click(object sender, RoutedEventArgs e)
        {
            App minhaApp = (App)App.Current;
            var ReclamacaoAlterado = ViewModel.ReclamacaoTemporario;

            bool resolvido = false;
            if (checkBoxResolvido.IsChecked == true)
            {
                resolvido = true;

            }

            ReclamacaoAlterado.Status = resolvido;
            var posicaoAlterado = minhaApp.ReclamacaoFontesDados.reclamacao.FindIndex(f => f.IdReclamacao == ReclamacaoAlterado.IdReclamacao);
            minhaApp.ReclamacaoFontesDados.reclamacao[posicaoAlterado] = ReclamacaoAlterado;
            bool ok = await minhaApp.ReclamacaoFontesDados.Save(App.FileName);
            if (ok)
            {
                this.ViewModel.ReclamacaoAtual = minhaApp.ReclamacaoFontesDados.reclamacao.Where(f => f.IdReclamacao == ReclamacaoAlterado.IdReclamacao).FirstOrDefault();

                this.ViewModel.ReclamacaoTemporario = new Reclamacao()
                {
                    IdReclamacao = ReclamacaoAlterado.IdReclamacao,
                    Bairro = ReclamacaoAlterado.Bairro,
                    Desc = ReclamacaoAlterado.Desc,
                    Titulo = ReclamacaoAlterado.Titulo,
                    Data = ReclamacaoAlterado.Data,
                    Endereco = ReclamacaoAlterado.Endereco,
                    Categoria = ReclamacaoAlterado.Categoria,
                    Status = ReclamacaoAlterado.Status,
                    latitude = ReclamacaoAlterado.latitude,
                    longitude = ReclamacaoAlterado.longitude
                                               
                };
                var dialog = new MessageDialog("Reclamação alterado com sucesso");
                await dialog.ShowAsync();
                this.Frame.GoBack();
            }
            else
            {
                var dialog = new MessageDialog("Falha no armazenamento da Reclamação");
                await dialog.ShowAsync();
            }
        }

        private void btCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.GoBack();
        }

        private async void btRemover_Click(object sender, RoutedEventArgs e)
        {
            var filmeRemovido = ViewModel.ReclamacaoAtual;
            App minhaApp = (App)App.Current;
            var posicaoRemocao = minhaApp.ReclamacaoFontesDados.reclamacao.FindIndex(f => f.IdReclamacao == filmeRemovido.IdReclamacao);
            minhaApp.ReclamacaoFontesDados.reclamacao.RemoveAt(posicaoRemocao);
       //     minhaApp.ReclamacaoFontesDados.reclamacao.RemoveAll(f => f.IdReclamacao == 0);
            bool ok = await minhaApp.ReclamacaoFontesDados.Save(App.FileName);
            if (ok)
            {
                var dialog = new MessageDialog("Reclamação removida com sucesso");
                await dialog.ShowAsync();
                
                this.Frame.GoBack();
            }
            else
            {
                minhaApp.ReclamacaoFontesDados.reclamacao.Insert(posicaoRemocao, filmeRemovido);
                var dialog = new MessageDialog("Falha na remoção da Reclamação");
                await dialog.ShowAsync();
            }
        }

        private void Marcado(object sender, RoutedEventArgs e)
        {



        }
    }
}
