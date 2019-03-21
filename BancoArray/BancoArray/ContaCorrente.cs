namespace BancoArray
{
    public class ContaCorrente : Conta
    {
        public override void Saca(double valor)
        {
            base.Saca(valor + 0.05);
        }
    }
}
