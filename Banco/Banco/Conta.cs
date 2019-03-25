using System;

namespace Banco
{
    public abstract class Conta
    {        
        public int Numero { get; set; }
        public double Saldo { get; protected set; }
        internal Cliente Titular { get; set; }

        public abstract void Deposita(double valor);
        /*{
            this.Saldo += valor;
        }*/

        public abstract void Saca(double valor);
        /*{
            this.Saldo -= valor;
        }*/
    }
}