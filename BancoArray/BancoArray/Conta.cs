using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoArray
{
    public abstract class Conta
    {
        private static int numeroDeConta = 0;

        public Conta()
        {
            this.Numero = numeroDeConta;
            numeroDeConta++;
        }
        public static int ProximaConta()
        {            
            return numeroDeConta;
        }

        public Cliente Titular { get; set; }
        public int Numero { get; set; }
        public double Saldo { get; protected set; }

        public abstract void Deposita(double valor);
        /*{
            this.Saldo += valor;
        }*/  //used in virtual class

        public abstract void Saca(double valor);
        /*{
            this.Saldo -= valor;
        }*/ //used in virtual class
    }
}
