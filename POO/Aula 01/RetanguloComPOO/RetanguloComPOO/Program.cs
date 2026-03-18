using RetanguloComPOO;
using static System.Console;
Retangulo x = new Retangulo();
Retangulo y = new Retangulo();

WriteLine("Digite as medidas do retangulo X");
Write("Digite a  altura do retangulo X: ");
x.altura = double.Parse(ReadLine());
Write("Digite a  largura do retangulo X: ");
x.largura = double.Parse(ReadLine());

WriteLine("Digite as medidas do retangulo Y");
Write("Digite a altura do retangulo Y: ");
y.altura = double.Parse(ReadLine());
Write("Digite a largura do retangulo Y: ");
y.largura = double.Parse(ReadLine());

WriteLine($"A area do retangulo X é de {x.Area()}");
WriteLine($"A area do retangulo Y é de {y.Area()}");
WriteLine($"Perimetro do retangulo X = {x.Perimetro()}");
WriteLine($"Perimetro do retangulo Y = {y.Perimetro()}");
WriteLine($"Diagonal do retangulo X = {x.Diagonal()}");
WriteLine($"Diagonal do retangulo Y = {y.Diagonal()}");

ReadKey();