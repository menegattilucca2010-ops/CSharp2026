using Figuras.Classes.Enumeracoes;

namespace Figuras.Classes.Entidades
{
    internal class Retangulo : Forma
    {
		//Campos
		private double largura;
		private double altura;

        //Propriedades
        public  double Largura
		{
			get { return largura; }
			set { largura = value; }
		}
		public double Altura
		{
			get { return altura; }	
			set { altura = value; }
		}

		//Construtor
        public Retangulo(Cor corDaForma, double largura, double altura) : base(corDaForma)
        {
			Largura = largura;
			Altura = altura;
        }

        /// <summary>
        /// Calcule a área forma usando as dimensões atuais
        /// </summary>
        /// <returns>O valor área calcula com base na largura e altura do retâgulo.</returns>

        public override double Area() => Largura * Altura;

    }
}
