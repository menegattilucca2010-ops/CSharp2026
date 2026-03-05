using static System.Console;
//Declaraçao de variaveis = 0, contagem = 0
int visitantes = 0, contagem = 0;
double altura_max = 0, altura_min = 0, altura = 0;
try
{
//Entrada de dados
Write("Digite o número de visitantes: ");
visitantes = int.Parse(ReadLine());
Write("Digite a altura máxima: ");
altura_max = double.Parse(ReadLine());
Write("Digite a altura minima: ");
altura_min = double.Parse(ReadLine());
//Processamento de dados
for(int i = 0; i<visitantes; i++)
{
    Write($"Digite a altura da pessoa n° {i+1}: ");
    altura = int.Parse(ReadLine());
    if ((altura >= altura_min) & (altura <= altura_max))
    {
        contagem++;
    }
}
WriteLine($"O número de pessoas que podem entrar no parque é de {contagem}");
}
catch (Exception ex)
{
    WriteLine($"Valor invaido,digite numerais, Erro = {ex.Message}");
}
