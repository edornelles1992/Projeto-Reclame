using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map.Classes
{
    public class ColecaoReclamacao
    {
        public List<Reclamacao> reclamacao;

        public ColecaoReclamacao()
        {
            reclamacao = new List<Reclamacao>();
            
        }



        

        public List<Reclamacao> Reclamacao
        {
            get { return reclamacao; }
        }

        async public Task<bool> Save(string fileName)
        {
            return await StorageHelper.WriteFileAsync(fileName, reclamacao, StorageHelper.StorageStrategies.Local);
        }

        public async Task<bool> Load(string fileName)
        {
            bool ok = false;
            try
            {
                reclamacao = await StorageHelper.ReadFileAsync<List<Reclamacao>>(fileName, StorageHelper.StorageStrategies.Local);
                if (reclamacao != null)
                {
                    ok = true;
                }
            }
            catch (Exception e)
            {
                ok = false;
            }
            return ok;
        }
    }
}
