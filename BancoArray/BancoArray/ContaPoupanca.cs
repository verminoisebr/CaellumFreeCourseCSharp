namespace BancoArray
{
    public class ContaPoupanca: Conta
    {
        public override void Saca(double valor)
        {
            base.Saca(valor+0.05);
        }

        public override void Deposita(double valor)
        {
            base.Deposita(valor-0.10);
        }
    }
}
