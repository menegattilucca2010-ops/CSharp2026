using static System.Console;
using static System.Linq.Enumerable;
//Declaração de variveis
int n;
//Entrada de dados
Write("Quantos numeros você vai digirar ? ");
n = int.Parse(ReadLine());
if (n < 0)
{
    WriteLine("Valor invalido, digite somente números positivos");
}
else if (n > 10)
{
    WriteLine("Maximo de valores para digitar igual a 10");
    WriteLine("Tente novmente");
}
else
{
    //Declaração do vetor
    int [] numeros = new int [n];
    for (int i = 0; i < numeros.Length ; i++)
    {
        Write($"Digite o {i+1}° número: ");
        numeros [i] = int.Parse(ReadLine());
    }
    WriteLine("Numeros negativos: ");
    foreach(int item in Range(0, numeros.Length))
    {
        if (numeros[item] < 0)
        {
            WriteLine(numeros[item]);
        }
    }
}
