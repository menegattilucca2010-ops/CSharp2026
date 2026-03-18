using Exemplo_com_POO;
using static System.Console;
//Instanciação dos triangulos X e Y
Triangulo x = new Triangulo();
Triangulo y = new Triangulo();
//Entrada de dados
WriteLine("Digite as meidas do triangulo X");
Write("Digite a medida de A: ");
x.ladoA = double.Parse(ReadLine());
Write("Digite a medida de B: ");
x.ladoB = double.Parse(ReadLine());
Write("Digite a medida de C: ");
x.ladoC = double.Parse(ReadLine());

WriteLine("Digite as meidas do triangulo Y");
Write("Digite a medida de A: ");
y.ladoA = double.Parse(ReadLine());
Write("Digite a medida de B: ");
y.ladoB = double.Parse(ReadLine());
Write("Digite a medida de C: ");
y.ladoC = double.Parse(ReadLine());

//Saide de dados
WriteLine($"Área do triangulo X é de {x.Area()}");
WriteLine($"Área do triangulo Y é de {y.Area()}");
ReadKey();
