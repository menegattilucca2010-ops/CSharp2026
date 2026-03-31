using static System.Console;
using Heranca;

PessoaFisica lucca = new PessoaFisica(12345, "Lucca");
PessoaJuridica senai = new PessoaJuridica(54321, "Skaf", 12000.00);

WriteLine(lucca);//Imprimir somente o objeto
WriteLine(lucca.ToString());//Imprimi e converte o obj p/ string
