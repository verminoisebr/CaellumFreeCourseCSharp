using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoArray
{
    public class Conta
    {
        public Cliente Titular { get; set; }
        public int Numero { get; set; }
        public double Saldo { get; private set; }

        public virtual void Deposita(double valor)
        {
            this.Saldo += valor;
        }

        public virtual void Saca(double valor)
        {
            this.Saldo -= valor;
        }
    }
}
