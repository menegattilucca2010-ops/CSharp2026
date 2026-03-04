using static System.Console;
static void Total(int quantidade, double valor)
{
    WriteLine($"O valor total é de R$ {quantidade * 5.00}");
}
//declaração de variáveis
int codigo,quantidade;
//entrada de dados
try{
Write("Digite o codigo do produto: ");
codigo = int.Parse(ReadLine());
Write("Digite a quantidade: ");
quantidade = int.Parse(ReadLine());
switch (codigo)
{
    case 1:
        Total(quantidade, 5.00);
        //WriteLine($"O valor total é: {quantidade * 5.00}");
        break;
    case 2:
        Total(quantidade, 4.50);
        //WriteLine($"O valor total é: {quantidade * 4.50}");
        break;
    case 3:
        Total(quantidade, 3.75);
        //WriteLine($"O valor total é: {quantidade * 3.75}");
        break;
    case 4:
        Total(quantidade, 8.99);
        //WriteLine($"O valor total é: {quantidade * 8.99}");
        break;
    case 5:
        Total(quantidade, 11.33);
        //WriteLine($"O valor total é: {quantidade * 11.33}");
        break;
        default:
        WriteLine("Codigo do produto nao cadastrado");
        break;
}
}
catch (Exception ex)
{
    WriteLine ($"Digite valores validos, erro: {ex.Message}");
}
