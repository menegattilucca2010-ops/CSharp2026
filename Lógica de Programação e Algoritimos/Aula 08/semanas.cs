// o usuario vai digitar um valor de 1 a 7 e o programa vai mostrar o dia da semana correspondente ao numero digitado pelo usuario

//declaração de variaveis 
using static System.Console;

int valor;
//entrada de dados
Write("Digite um numero de 1 a 7: ");
valor = int.Parse(Console.ReadLine());
if (valor == 1)
{
    WriteLine("domingo");
}
else if (valor == 2)
{
    WriteLine("segunda");
}
else if (valor == 3)
{
    WriteLine("terça");
}
else if (valor == 4)
{
    WriteLine("quarta");
}
else if (valor == 5)
{
    WriteLine("quinta");
}
else if (valor == 6)
{
    WriteLine("sexta");
}
else if (valor == 7)
{
    WriteLine("sabado");
}
else
{
    WriteLine("Numero fora do intervalo de 1 a 7");
}
