using static System.Console;
try{
    //Decalaração de variaveis
    double a, b, c, areaQuadrado, areaTriangulo, areaTrapezio;
    //Entrada de dados
    Write("Digite a mededida A: ");
    a = double.Parse(ReadLine());
    Write("Digite a medida B: ");
    b = double.Parse(ReadLine());
    Write("Digite a medida de C: ");
    c = double.Parse(ReadLine());
    //processamento de dados
    areaQuadrado = a * a;
    areaTriangulo = (a * b) / 2;
    areaTrapezio = ((a + b) * c) / 2 ;
    //Saida de dados
    WriteLine($"Area do quadrado: {areaQuadrado:F4}");
    WriteLine($"Area do triangulo: {areaTriangulo:F4}");
    WriteLine($"Area do trapezio: {areaTrapezio:F4}");
}
catch(Exception)
{
    WriteLine("Valores invalidos inseridos, programa encerrado!");
}