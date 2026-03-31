namespace Banco_Master
{
    internal class ContaParaEmpresa : Conta
    {
        private double limiteDeEmprestimo;

		public double 
		{
			get { return limiteDeEmprestimo; }
			set { limiteDeEmprestimo = value; }
		}


	}
}
