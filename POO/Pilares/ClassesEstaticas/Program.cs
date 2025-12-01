// See https://aka.ms/new-console-template for more information
using ClassesEstaticas;
Console.Clear();
Console.WriteLine("Bem vindo ao programa");
// Console.WriteLine();

// Console.Write($"Digite um número: ");
// float a = float.Parse(Console.ReadLine());
// Console.Write($"Digite outro número: ");
// float b = float.Parse(Console.ReadLine());

// //uso da classe estática de forma auxiliar
// float r = CalculosMatematicos.Somar(a, b);
// Console.WriteLine($"Soma: {r}");

// r = CalculosMatematicos.Subtrair(a, b);
// Console.WriteLine($"Subtração: {r}");

// r = CalculosMatematicos.Multiplicar(a, b);
// Console.WriteLine($"Multiplicação: {r}");

// r = CalculosMatematicos.Dividir(a, b);
// Console.WriteLine($"Divisão: {r}");




// Solicitar ao usuário 2 núemros reais e informar qual é o maior e qual é o menor dos números. Para isso você deve utilizar a classe Math, utilitária do C#

Console.Write($"Digite o primeiro número:");
float n1 = float.Parse(Console.ReadLine());

Console.Write($"Digite o segundo número:");
float n2 = float.Parse(Console.ReadLine());

if (n1 == n2)
{
    Console.WriteLine($"Os dois números são iguais");

}
else
{
    Console.WriteLine($"Maior é: {Math.Max(n1, n2)}");
    Console.WriteLine($"Menor é: {Math.Min(n1, n2)}");
}
