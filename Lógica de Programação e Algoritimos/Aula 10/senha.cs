using static System.Console;
//Declaraçao de variaveis
const int SENHAFIXA = 2002;
int senha, contagem = 0;
//Entrada de dados
Write("Digite a senha: ");
senha = int.Parse(ReadLine());
//Processaento de dados
while (senha != SENHAFIXA)
{
    if (contagem >= 3)
    {
        WriteLine("Acesso bloqueado");
        break;
    }
    contagem++;
    Write("Senha incorreta, digite novamente: ");
    senha = int.Parse(ReadLine());
}
if (contagem < 3)
{
WriteLine("Acesso permitido!");
}
else
{
    WriteLine("Acesso negado");
}
