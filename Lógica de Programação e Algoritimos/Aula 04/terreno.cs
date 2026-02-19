using static System.Console;
//declaração de variaveis
double largura, comprimento, valor, area, preco;
//entrada de dados
Write("Digite a largura do terreno: ");
largura = double.Parse(ReadLine());
Write("Digite o comprimento do terreno: ");
comprimento = double.Parse(ReadLine());
WriteLine("Digite o valor do metro quadrado do terreno: ");
valor = double.Parse(ReadLine());
//processamento de daodos
area= largura * comprimento;
preco = area *  valor;
//saida de dados
WriteLine($" A area do terreno é de {area} e o preço do terreno é de R${preco}");