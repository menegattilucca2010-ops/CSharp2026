using ConversorDeMoeda;
using static System.Console;
using static System.ConsoleColor;

Title = "Conversor de Moedas";
Write("Qual é a cotação do dolár? ");
ForegroundColor = Red;
double cotacao = double.Parse(ReadLine());
ResetColor();
Write("Quantos doláres você vai comprar? ");
ForegroundColor = Red;
double qtd = double.Parse(ReadLine());
ResetColor();

WriteLine($"Valor a ser pago em reais = {Dolar.Converter(cotacao, qtd):F2}");