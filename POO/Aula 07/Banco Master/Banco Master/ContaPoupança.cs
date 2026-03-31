namespace Banco_Master
{
    internal class ContaPoupança : Conta
    {
        private double taxaDeJuros;

		public double Juros
		{
			get { return taxaDeJuros; }
			set { taxaDeJuros = value; }
		}

        public void AtualizacaoDeSaldo()
		{
			SaldoConta += SaldoConta * taxaDeJuros;
		}

		public void Saque(double quantia)
		{
			SaldoConta -= quantia;
		}

    }
}
