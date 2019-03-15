using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe
{
    class Conta
    {
        public Cliente titular;
        public int numero;
        public double saldo;
        public int idade;

        public void Deposita (double valor)
        {
            this.saldo += valor;
        }
        public bool Saca (double valor)
        {
            if (this.saldo >= valor && this.idade>18)
            {
                this.saldo -= valor;
                return true;
            }
            else if (this.saldo >= valor && this.idade < 18)
            {
                if (valor >= 200)
                {
                    valor = 200;
                }
                this.saldo -= valor;
                return true;
            }

                return false;
        }
        public bool Transfere(double valor, Conta contaDestino)
        {
            if(this.saldo >= valor)
            {
                this.Saca(valor);
                contaDestino.Deposita(valor);
                return true;
            }
            return false;            
        }
    }
}
