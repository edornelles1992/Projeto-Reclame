using Map.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map.ViewModels
{
   public  class CadastroPageViewModel
    {
        public Reclamacao ReclamacaoAtual { get; set; }

        public CadastroPageViewModel()
        {
            ReclamacaoAtual = new Reclamacao();
        }
    }
}
