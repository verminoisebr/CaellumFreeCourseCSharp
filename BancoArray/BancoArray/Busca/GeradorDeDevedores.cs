using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoArray.Busca
{
    class GeradorDeDevedores
    {
        public List<string> GeraList()
        {
            List<string> nomes = new List<string>();
            for (int i = 0; i <= 3000; i++)
            {
                nomes.Add("Devedor " + i);
            }
            return nomes;
        }
    }
}
