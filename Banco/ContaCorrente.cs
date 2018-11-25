namespace Banco
{
    class ContaCorrente : Conta, ITributavel
    {
        public override void Saca(double valor)
        {
            this.Saldo -= valor + 0.05;
        }

        public override void Deposita(double valor)
        {
            this.Saldo += valor;
        }

        public double CalculaTributos()
        {
            return this.Saldo * 0.05;
        }
    }
}