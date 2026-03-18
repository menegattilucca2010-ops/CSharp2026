namespace RetanguloComPOO
{
    internal class Retangulo
    {
        public double altura;
        public double largura;

        public double Area()
        {
            double area = altura * largura;
            return area;
        }
        public double Perimetro()
        {
            return 2 * (largura + altura);
        }
        public double Diagonal()
        {
            return Math.Sqrt(largura * largura + altura * altura);
        }

    }
}