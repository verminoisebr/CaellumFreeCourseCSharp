using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe
{
    class Cliente
    {
        public string nome, rg, cpf, endereco;
        public int idade;
        public bool EhMaiorDeIdade()
        {
            if (this.idade >= 18)
            {
                return true;
            }
            return false;
        }

    }
}
