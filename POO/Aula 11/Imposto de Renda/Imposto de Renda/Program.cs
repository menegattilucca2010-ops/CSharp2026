using Imposto_de_Renda.Classes.Entidades;
using static System.Console;

List<Contribuintes> contribuintes = new();

Write("Digite o numero de contribuintes: ");
int qtd = int.Parse(ReadLine());

for(int i = 0; i < qtd; i++)
{
    WriteLine($"Dados do contribuinte: {i + 1} ");
    Write($"Pessoa jurídica ou física (J/F): ");
    char escolha = char.Parse(ReadLine().ToLower());
    if (escolha == 'j')
    {
        WriteLine("Qual é o numero de funcionarios" +
            "\n\t1 - Renda anual" +
            "\n\t2 - Nome");
        Write("Digite o nome da pessoa júridica: ");
        string nome = (ReadLine());
        Write("Digite a renda anual da empresa: ");
        double rendaAnual = double.Parse(ReadLine());
        Write("Digite o numero de funcionarios: ");
        int numeroDeFuncionario = int.Parse(ReadLine());
    }
    else if (escolha == 'f')
    {
        WriteLine("Qual é a quantidade gasta com saúde" +
            "\n\t1 - Renda anual" +
            "\n\t2 - Nome");
        Write("Digite a quantidade gasta com saúde: ");
        double gastoComSaude = double.Parse(ReadLine());
        Write("Digite a renda anual da pessoa física: ");
        double rendaAnual = double.Parse(ReadLine());
        Write("Digite o nome da pessoa física: ");
        string nome = (ReadLine());
    }
}


foreach (var imposto in contribuintes)
{
    Write(imposto.ToString());
}