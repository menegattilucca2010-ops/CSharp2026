//Entrada de dados
Console.WriteLine("Digite o seu nome: ");
string nome = Console.ReadLine();//Entarada de dados
System.Console.WriteLine($"O valor digitado é de {nome}");
System.Console.WriteLine("digite o 1º primeiro numero: ");
double x = double.Parse(Console.ReadLine());//Converção de dados
System.Console.WriteLine("digite o 2º primeiro numero: ");
double y =double.Parse(Console.ReadLine());//Converção de dados
//Processamento de dados
double soma = x +y;
//Saida de dados
System.Console.WriteLine($"A soma dos dois valores é de {soma}");
