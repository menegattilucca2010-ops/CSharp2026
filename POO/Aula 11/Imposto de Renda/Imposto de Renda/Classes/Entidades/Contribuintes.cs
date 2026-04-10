using Imposto_de_Renda.Classes.Contratos;
namespace Imposto_de_Renda.Classes.Entidades
{
    internal abstract class Contribuintes : Iimposto
    {
		private string nome;
		private double renda_anual;


        protected string Nome
		{
			get { return nome; }
			set { nome = value; }
		}
		protected double  RendaAnual
		{
			get { return renda_anual; }
			set { renda_anual = value; }
		}


        public Contribuintes(string nome, double rendaAnual)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
        }


		public abstract double Imposto();
    }
}
