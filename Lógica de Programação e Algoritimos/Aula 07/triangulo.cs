using static System.Console;
double a, b, c, area;
Write("Digite o valor de a: ");
a = double.Parse(ReadLine());
Write("Digite o valor de b: ");
b = double.Parse(ReadLine());
Write("digite o valor de c: ");
c = double.Parse(ReadLine());
if (a < b + c & b < a + c & c < a + b)
{
    double p = (a + b +c) / 2;
    area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    WriteLine("Forma um triangulo");
    WriteLine($"Area do triangulo: {area:F2}");
}
else
{
    WriteLine("Não forma um triangulo");
    area = ((a + b) * c) / 2;
    WriteLine($"Area do trapézio: {area:F2}");
}
