using static System.Console;

int altura_maxima, altura_minima, numero_de_pessoas, altura, contagem = 0;
try
{
    Write("Digite o numero de alturas das pessoas: ");
    numero_de_pessoas = int.Parse(ReadLine());
    Write("Digite a altura mínima (cm) ");
    altura_minima = int.Parse(ReadLine());
    Write("Digite a altura máxima (cm) ");
    altura_maxima = int.Parse(ReadLine());
    for (int i=0; i<numero_de_pessoas; i++)
    {
        Write($"Digite a altura da pessoa número {i+1}: ");
        altura = int.Parse(ReadLine());

        if (altura >= altura_minima & altura <= altura_maxima)
            {
                contagem++;
            }
    }

    WriteLine($"{numero_de_pessoas} pessoas que estão entre {altura_minima} e {altura_maxima}");

}
catch (Exception ex)
{
    WriteLine("ERRO: Entrada invalida. Por favor, insira numeros inteiros validos", ex.Message);
}
