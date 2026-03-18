using static System.Console;
Title = ("Calculadora de triangulos");
//Entrada de dados
WriteLine("Digite as medidas do triangulo X");
Write("Digite o valor de a: ");
double ax = double.Parse(ReadLine());
Write("Digite o valor de b: ");
double bx = double.Parse(ReadLine());
Write("Digite o valor de c: ");
double cx = double.Parse(ReadLine());

WriteLine("Digite as medidas do triangulo Y");
Write("Digite o valor de a:");
double ay = double.Parse(ReadLine());
Write("Digite o valor de b:");
double by = double.Parse(ReadLine());
Write("Digite o valor de c:");
double cy = double.Parse(ReadLine());

//Processamento de dados
double px = (ax + bx + cx) / 2;
double py = (ay + by + cy) / 2;
double areax = Math.Sqrt(px * (px - ax) * (px - bx) * (px - cx));
double areay = Math.Sqrt(py * (py - ay) * (py - by) * (py - cy));

//Saidsa de dados
WriteLine($"A Área do triagulo x é de {areax:F2}");
WriteLine($"A Área do triagulo y é de {areay:F2}");


if (areax > areay)
{
    WriteLine("Maior área é do triangulo X");
}
else if (areay > areax)
{
    WriteLine("Maior área é do triangulo Y");
}
else
{
    WriteLine("Os triangulos de áreas iguais");
}
ReadKey();
