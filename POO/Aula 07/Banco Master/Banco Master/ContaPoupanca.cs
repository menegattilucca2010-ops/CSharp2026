namespace Banco_Master
{
    internal class ContaPoupanca : Conta
    {
        //Campo
        private double juros;

        //Propriedades
		public double TaxaDeJuros
		{
			get { return juros; }
			set { juros = value; }
		}

        //Construtores

        public ContaPoupanca(int numeroConta, string titularConta, double TaxaJuros) : base(numeroConta, titularConta)
        {
            TaxaDeJuros = TaxaJuros;
        }

        public ContaPoupanca(int numeroConta, string titularConta, double saldoConta, double TaxaJuros)
            : base(numeroConta, titularConta, saldoConta)
        {
            TaxaDeJuros = TaxaJuros;
        }

        public void AtualizacaoDeSaldo()
		{
            SaldoConta = SaldoConta + (SaldoConta * TaxaDeJuros);
		}

		public override void Saque(double quantia)
		{
                SaldoConta -= quantia;
		}

    }
}
