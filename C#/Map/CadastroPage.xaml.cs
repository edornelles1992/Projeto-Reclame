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
using Windows.Graphics.Imaging;
using Windows.Storage;
using Windows.Storage.Pickers;
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
using Windows.UI.Xaml.Navigation;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Map
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CadastroPage : Page
    {
     //   public static int contReclamacao;
        public CadastroPageViewModel ViewModel { get; set; }
        public MainPage rootPage;
        double lat;
        double longi;
        public int contID;
        StorageFile file;

        public CadastroPage()
        {
           
            this.InitializeComponent();
            this.ViewModel = new CadastroPageViewModel();
            PickAFileButton.Click += new RoutedEventHandler(PickAFileButton_Click);


        }

      


        private async void btSalvar_Click(object sender, RoutedEventArgs e)
        {
            if (listBoxCateg.SelectedItem == null || listBoxCateg.SelectedItem.Equals("Selecione a Categoria:")) {
                var dialog = new MessageDialog("Categoria não especificada!");
                await dialog.ShowAsync();
                return;
            }
            if (listBoxBairro.SelectedItem == null || listBoxBairro.SelectedItem.Equals("Selecione o Bairro:")) {
                var dialog = new MessageDialog("Bairro não especificado!");
                await dialog.ShowAsync();
                return;
            }

            App minhaApp = (App)App.Current;
            //string aux = listBoxCateg.SelectedItem.ToString();
            //  string.Format("dd/mm/yyyy", aux);
            //  DateTime.TryParse(aux);
      //      ViewModel.ReclamacaoAtual.foto = file;
            ViewModel.ReclamacaoAtual.Data = DataReclamacao.Date.ToString();
            ViewModel.ReclamacaoAtual.IdReclamacao = contID;
            ViewModel.ReclamacaoAtual.latitude = lat;
            ViewModel.ReclamacaoAtual.longitude = longi;
            ViewModel.ReclamacaoAtual.Categoria = listBoxCateg.SelectedItem.ToString();
            ViewModel.ReclamacaoAtual.Bairro = listBoxBairro.SelectedItem.ToString();
            minhaApp.ReclamacaoFontesDados.Reclamacao.Add(ViewModel.ReclamacaoAtual);
            bool ok = await minhaApp.ReclamacaoFontesDados.Save(App.FileName);
            if (ok)
            {
                
          
                var dialog = new MessageDialog("Reclamação inserida com sucesso.");                
                await dialog.ShowAsync();               
                this.Frame.GoBack();
               
            }
            else
            {
                minhaApp.ReclamacaoFontesDados.Reclamacao.RemoveAt(minhaApp.ReclamacaoFontesDados.Reclamacao.Count - 1);
                var dialog = new MessageDialog("Falha no armazenamento da reclamação");
                await dialog.ShowAsync();
            }

        }

        private void btCancelar_Click(object sender, RoutedEventArgs e)
        {
           
            this.Frame.GoBack();
            
        }
        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {

            base.OnNavigatedFrom(e);
            bool suspending = ((App)App.Current).IsSuspending;
            if (suspending)
            {
                // Armazenar o estado temporário dos campos de texto
                var composite = new ApplicationDataCompositeValue();
                composite["textBoxTitulo"] = textTitulo.Text;
                composite["textData"] = DataReclamacao.Date.ToString();
                composite["textBairro"] = listBoxBairro.SelectedItem.ToString();
                composite["textCategoria"] = listBoxCateg.SelectedItem.ToString();
                composite["textDescricao"] = textDescricao.Text;
                composite["textID"] = contID;
                composite["textDescricao"] = textEndereco.Text;
              
                
     //           ViewModel.ReclamacaoAtual.IdReclamacao = contReclamacao;
               

                ApplicationData.Current.LocalSettings.Values["TheWorkInProgress"] = composite;
            }
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            App minhaApp = (App)App.Current;
            var x = minhaApp.ReclamacaoFontesDados.Reclamacao;
            rootPage = MainPage.Current;
            contID = rootPage.numRecl+1;
            textID.Text = contID.ToString();
            listBoxCateg.ItemsSource = new List<String> { "Selecione a Categoria:","Buraco na rua", "Falta de sinalização", "Sujeira na rua", "Falta de segurança" , "Iluminação Pública" ,"Outros"};
            listBoxBairro.ItemsSource = new List<String> { "Selecione o Bairro:","Centro", "Bom Fim", "Partenon", "Cidade Baixa", "Jardim do Salso", "Santana", "Floresta","Petropolis","Rubem Berta","Humaitá" };
            
            lat = rootPage.latitude;
            longi = rootPage.longitude;
            base.OnNavigatedTo(e);
           
            if (e.NavigationMode == NavigationMode.New)
            {
                // Se é uma navegação nova para a página, limpar o estado temporário
                ApplicationData.Current.LocalSettings.Values.Remove("TheWorkInProgress");
            }
            else
            {
                // Carregar o estado temporário dos componentes de texto
                if (ApplicationData.Current.LocalSettings.Values.ContainsKey("TheWorkInProgress"))
                {
                    var composite = ApplicationData.Current.LocalSettings.Values["TheWorkInProgress"] as ApplicationDataCompositeValue;
                    this.ViewModel.ReclamacaoAtual.Titulo = (string)composite["textTitulo"];
                    this.ViewModel.ReclamacaoAtual.Data = DataReclamacao.Date.ToString();
                    this.ViewModel.ReclamacaoAtual.Bairro = listBoxBairro.SelectedItem.ToString();
                    this.ViewModel.ReclamacaoAtual.Desc = (string)composite["textDescricao"];
         //           this.ViewModel.ReclamacaoAtual.foto = file;
                 this.ViewModel.ReclamacaoAtual.Categoria = listBoxCateg.SelectedItem.ToString();
                    //  contReclamacao++;
                    //   textBoxID.Text = contReclamacao.ToString();
                    this.ViewModel.ReclamacaoAtual.IdReclamacao = contID;
                    this.ViewModel.ReclamacaoAtual.Endereco = (string)composite["textEndereco"];
                    // Limpar o estado temporário
                    ApplicationData.Current.LocalSettings.Values.Remove("TheWorkInProgress");
                }
            }
        }

        private async void PickAFileButton_Click(object sender, RoutedEventArgs e)
        {
            // Clear previous returned file name, if it exists, between iterations of this scenario
            OutputTextBlock.Text = "";

            FileOpenPicker openPicker = new FileOpenPicker();
            openPicker.ViewMode = PickerViewMode.Thumbnail;
            openPicker.SuggestedStartLocation = PickerLocationId.PicturesLibrary;
            openPicker.FileTypeFilter.Add(".jpg");
            openPicker.FileTypeFilter.Add(".jpeg");
            openPicker.FileTypeFilter.Add(".png");



           file = await openPicker.PickSingleFileAsync();






            if (file != null)          {               
              
                OutputTextBlock.Text = "Foto escolhida: " + file.Name;


                IRandomAccessStream fileStream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
                var localFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
        
                StorageFile photoFile = await localFolder.CreateFileAsync(file.Name, CreationCollisionOption.ReplaceExisting);
                using (var photoOutputStream = await photoFile.OpenStreamForWriteAsync())
                {
                    await fileStream.AsStreamForRead().CopyToAsync(photoOutputStream);
                }


      
                IRandomAccessStream fileStream1 = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
               
                BitmapImage bitmapImage = new BitmapImage();

         
                await bitmapImage.SetSourceAsync(fileStream1);
                image.Source = bitmapImage;
                ViewModel.ReclamacaoAtual.foto= file.Name;


            }
           





        }

        
    }
}
