namespace Banco_Master
{
    internal class ContaParaEmpresa : Conta
    {
        private double limite;

		public double LimiteDeEmprestimo
		{
			get { return limite; }
			set { limite = value; }
		}

        public ContaParaEmpresa(int numeroConta, string titularConta, double limite) 
            : base(numeroConta, titularConta)
        {
            LimiteDeEmprestimo = limite;
        }

        public ContaParaEmpresa(int numeroConta, string titularConta, double saldoConta, double limite) 
            : base(numeroConta, titularConta, saldoConta)
        {
            LimiteDeEmprestimo = limite;
        }

        public void Emprestimo( double quantia)
        {
            LimiteDeEmprestimo -= quantia;
            SaldoConta += quantia;
        }

    }
}
