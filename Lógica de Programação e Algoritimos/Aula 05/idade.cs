using static System.Console;
int anos, meses, dias, diasDigitados;
Write("Digite a quantidade de dias: ");
diasDigitados = int.Parse(ReadLine());
anos = diasDigitados / 365;
meses = (diasDigitados % 365) / 30;
dias = (diasDigitados % 365) % 30;
WriteLine("idade " + anos + " anos, " + meses + " meses e " + dias + " dias");