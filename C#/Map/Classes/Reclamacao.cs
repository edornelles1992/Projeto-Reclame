using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.UI.Xaml.Media.Imaging;

namespace Map.Classes
{
    /// <summary>
    /// Abrir reclamação. Para abrir uma reclamação o usuário deve informar: um título, uma breve descrição do
    ///problema que está relatando, a data, bairro e endereço onde foi verificado o problema.O usuário também
    ///deve categorizar o tipo de problema encontrado, como por exemplo: iluminação pública, preservação de vias
    ///públicas, preservação de calçadas, etc.Opcionalmente o usuário pode adicionar uma imagem.
    /// </summary>
    public class Reclamacao
    {
        public Reclamacao() {
            Status = false; //false = reclamacao aberta 
           
        }


        public int IdReclamacao { get; set; }
        public string Titulo { get; set; }
        public string Desc { get; set; }
        public string Data { get; set; }
        public string Bairro { get; set; }
        public string Endereco { get; set; }
        public string Categoria { get; set; }
        public bool Status { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public string foto { get; set; }


    }
}
