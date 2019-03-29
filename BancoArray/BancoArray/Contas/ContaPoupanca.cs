using BancoArray.Contas;
namespace BancoArray
{
    public class ContaPoupanca: Conta, ITributavel
    {
        public override void Saca(double valor)
        {
            if (valor > this.Saldo)
            {
                throw new SaldoInsuficienteException();
            }
            this.Saldo -= (valor+0.05);
        }

        public override void Deposita(double valor)
        {
            if (valor < 0.0)
            {
                throw new System.ArgumentException();
            }
            this.Saldo += (valor-0.10);
        }
        public double CalculaTributo()
        {
            return this.Saldo * 0.02;
        }
    }
}
