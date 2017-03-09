using Map.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage.Streams;
using Windows.UI;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Maps;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Map
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
               public  double latitude;
        public  double longitude;      
        string localSelecionado;
        public BasicGeoposition localAtual;
        private List<Reclamacao> carregaLista;
        public int numRecl;        

        public static MainPage Current ; 

        public MainPage()
        {
           
            this.InitializeComponent();
            Current = this;
            App minhaApp = (App)App.Current;
            this.DataContext = minhaApp.ReclamacaoFontesDados;
            Map.Loaded += MyMap_Loaded;
            carregaLista = minhaApp.ReclamacaoFontesDados.reclamacao;
            

        }

        private void ReclamacaoListView_ItemClick(object sender, ItemClickEventArgs e)
        { 
            int codigo = ((Reclamacao)e.ClickedItem).IdReclamacao;
            this.Frame.Navigate(typeof(DetalhesPage), codigo);
        }

        private async void appBarButton1_Click(object sender, RoutedEventArgs e)
        {
            if (latitude == 0 || longitude == 0) {
                var dialog = new MessageDialog("Marque um local no mapa!");
                await dialog.ShowAsync();
                
                return;
            }


            this.Frame.Navigate(typeof(CadastroPage));

        }      


        private void MapControl_MapTapped(Windows.UI.Xaml.Controls.Maps.MapControl sender, Windows.UI.Xaml.Controls.Maps.MapInputEventArgs args)
        {
           
            localAtual = args.Location.Position;
            var posicao = args.Location.Position;
            var tappedGeoPosition = args.Location.Position;
            latitude = tappedGeoPosition.Latitude;
            longitude = tappedGeoPosition.Longitude;      

            localSelecionado = "Local Selecionado! \nLatitude:" + tappedGeoPosition.Latitude + "\nLongitude: " + tappedGeoPosition.Longitude;
            LocalClicado.Text = localSelecionado;
            
        }
        

        private void MyMap_Loaded(object sender, RoutedEventArgs e)
        { //carregar o mapa em porto alegre
            listBoxBairro.ItemsSource = new List<String> { "Selecione o Bairro:", "Centro", "Bom Fim", "Partenon", "Cidade Baixa", "Jardim do Salso", "Santana", "Floresta", "Petropolis", "Rubem Berta", "Humaitá" };
            listBoxCateg.ItemsSource = new List<String> { "Selecione a Categoria:", "Buraco na rua", "Falta de sinalização", "Sujeira na rua", "Falta de segurança", "Iluminação Pública", "Outros" };
            Map.Center =
                new Geopoint(new BasicGeoposition()
                {

                    Latitude = -30.0277,
                    Longitude = -51.2287
                });
            Map.ZoomLevel = 13;

            int contF = 0;
            int contT = 0;

            foreach (var reclamacao in carregaLista)
            {
                double latitude = reclamacao.latitude;
                double longitude = reclamacao.longitude;
             
                string status;
                if (reclamacao.Status == false)
                {
                    contF++;
                    status = "ms-appx:///Assets/MapPin.png";

                }
                else
                {
                    status = "ms-appx:///Assets/marcador_resolvido.png";
                    contT++;

                }


                BasicGeoposition snPosition = new BasicGeoposition() { Latitude = latitude, Longitude = longitude };
                Geopoint snPoint = new Geopoint(snPosition);

                MapIcon mapIcon = new MapIcon();
                mapIcon.Location = snPoint;
                mapIcon.NormalizedAnchorPoint = new Point(0.5, 1.0);
                mapIcon.Image = RandomAccessStreamReference.CreateFromUri(new Uri(status));
                mapIcon.ZIndex = 0;
                if (reclamacao.Titulo != null) { 
                mapIcon.Title = reclamacao.Titulo;
            }
                    Map.MapElements.Add(mapIcon);
                
            }

            textR.Text = "  Reclamações Resolvidas: " + contT + " | Reclamações Não Resolvidas: " + contF;
            numRecl = Map.MapElements.Count;
           
            txtTotalR.Text = "Total de Reclamações: " + numRecl;


           


        }

        private void SelecionaBairro(object sender, SelectionChangedEventArgs e)
        {
            if (listBoxBairro.SelectedItem.Equals("Selecione o Bairro:"))
            {
                return;
            }

            var total = from bairro in carregaLista
                        where bairro.Bairro == listBoxBairro.SelectedValue.ToString()
                        group bairro by bairro.Status
                       into grupoBairro
                        select new { NroTotal = grupoBairro.Count(), Status =grupoBairro.Key, Reclamacao=grupoBairro };

            if(total.Count()>0)
            {
                    infBairro.Text = "";
                    foreach (var g in total)
                    {

                        string resolvido = "Problemas não resolvidos: ";
                        if (g.Status == true)
                        {
                            resolvido = "Problemas resolvidos: ";

                        }

                        infBairro.Text += resolvido + g.NroTotal + "\n";

                    }
                    

            }
            else
            {
                    infBairro.Text = "Nenhuma reclamação encontrada";


                }


          
        }

        private void SelecionaCateg(object sender, SelectionChangedEventArgs e)
        {
            if (listBoxCateg.SelectedItem.Equals("Selecione a Categoria:")) {
                return;
            }
            var total = from categoria in carregaLista
                        where categoria.Categoria == listBoxCateg.SelectedValue.ToString()
                        group categoria by new { categoria.Status, categoria.Categoria } into grupoCateg

                        select new { Status = grupoCateg.Key, NroTotal = grupoCateg.Count(), Categoria = grupoCateg };

            //select new { NroTotal = grupoCateg.Count(), Status = grupoCateg.Key, Reclamacao = grupoCateg };

            if (total.Count() > 0)
            {
                infCateg.Text = "";
                foreach (var g in total)
                {

                    string resolvido = "Problemas não resolvidos: ";

                    if (g.Status.Status == true)
                    {
                        resolvido = "Problemas resolvidos: ";

                    }

                    infCateg.Text += resolvido + g.NroTotal + "\n";

                }


            }
            else
            {
                infCateg.Text = "Nenhuma reclamação encontrada";


            }
        }

       
    }
}
