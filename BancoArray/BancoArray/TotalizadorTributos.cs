using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoArray
{
    public class TotalizadorTributos
    {
        public double Total { get; private set; }
        public void Adiciona(ITributavel t)
        {
            this.Total += t.CalculaTributo();
        }

    }
}
