namespace Banco
{
    public class ContaPoupanca : Conta
    {
        public override void Deposita(double valor)
        {
            this.Saldo += (valor - 0.10);
        }

        public override void Saca(double valor)
        {
            this.Saldo -= (valor + 0.10);
            //base.Saca(valor + 0.10); In this case, variable saldo of conta may be private again instead protected 
        }
    }
}