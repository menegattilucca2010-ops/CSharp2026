namespace Master
{
    internal class ContaPJ : Conta
    {
		//Campo
		private double limite;

		//Propriedades
        public double LimiteConta
		{
			get { return limite; }
			set { limite = value; }
		}

		//Construtor
        public ContaPJ(int numeroConta, double saldoConta, Pessoa dadosCliente, double limite) : base(numeroConta, saldoConta, dadosCliente)
        {
			LimiteConta = limite;
        }

        //Metodos
        public void Emprestimo(double qtd)
        {
            LimiteConta -= qtd;
            SaldoConta += qtd;
        }


    }
}
