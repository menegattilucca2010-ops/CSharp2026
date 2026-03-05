using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        int totalTuristas = 0;

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Aplicativo de controle de fluxo carros");

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Parque Nacional os Lençóis Maranhenses\n");

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Bem-vindo ao aplicativo de controle de fluxo carros!");

        while (true)
        {
            Console.ResetColor();
            Console.Write("Digite o fluxo de carro (entrada/saida)\n" +
                          "ou sair para encerrar a aplicação: ");

            string opcao = Console.ReadLine().ToLower();

            if (opcao == "sair")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nSaindo do aplicativo...");
                break;
            }

            if (opcao != "entrada" && opcao != "saida")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro: Por favor, digite 'entrada' ou 'saida'.\n");
                continue;
            }

            Console.ResetColor();
            Console.Write("Digite o número de turistas: ");
            int turistas = int.Parse(Console.ReadLine());

            string dataHora = DateTime.Now.ToString(
                "ddd MMM dd HH:mm:ss yyyy",
                CultureInfo.InvariantCulture);

            if (opcao == "entrada")
            {
                totalTuristas += turistas;

                Console.WriteLine($"Entrada registrada em: {dataHora}");
                Console.WriteLine($"Entrada de {turistas} turistas registrada.");
            }
            else
            {
                totalTuristas -= turistas;

                Console.WriteLine($"Saída registrada em: {dataHora}");
                Console.WriteLine($"Saída de {turistas} turistas registrada.");
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Total de turistas no parque: {totalTuristas}\n");
        }

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Aplicativo encerrado.");
        Console.ResetColor();
    }
}
