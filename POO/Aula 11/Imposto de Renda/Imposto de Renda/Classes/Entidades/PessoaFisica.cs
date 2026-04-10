namespace Imposto_de_Renda.Classes.Entidades
{
    internal abstract class PessoaFisica : Contribuintes
    {
        private double gasto_com_saude;


        protected double GastoComSaude
        {
            get { return gasto_com_saude; }
            set { gasto_com_saude = value; }
        }


        public PessoaFisica(string nome, double rendaAnual, double gastoComSaude) : base(nome, rendaAnual)
        {
            GastoComSaude = gastoComSaude;
        }

        public override double Imposto()
        {
            double imposto;

            if (RendaAnual < 20000.0)
            {
                imposto = RendaAnual * 0.15;
            }
            else
            {
                imposto = RendaAnual * 0.25;
            }

            imposto -= GastoComSaude * 0.5;

            return Imposto();
        }
    }

}
}
