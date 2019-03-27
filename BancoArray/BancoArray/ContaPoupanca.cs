namespace BancoArray
{
    public class ContaPoupanca: Conta, ITributavel
    {
        public override void Saca(double valor)
        {
            this.Saldo -= (valor+0.05);
        }

        public override void Deposita(double valor)
        {
            this.Saldo += (valor-0.10);
        }
        public double CalculaTributo()
        {
            return this.Saldo * 0.02;
        }
    }
}
