//Tupla
using static System.Console;
var clodoaldo = (34, 34, "Heitor", "SENAI", 'B');

WriteLine($"Idade do clodoaldo: {clodoaldo.Item1} ");
WriteLine($"Idade do clodoaldo: {clodoaldo.Item2}");
WriteLine($"Nome do filho do clodoaldo: {clodoaldo.Item3}");
clodoaldo.Item1 = 54;
WriteLine($"Idade do clodoaldo: {clodoaldo.Item1}");

(int , int , int) numeros = (1 , 2 , 5);
WriteLine($"Números da tupla: {numeros.Item1}, {numeros.Item2}, {numeros.Item3}");
