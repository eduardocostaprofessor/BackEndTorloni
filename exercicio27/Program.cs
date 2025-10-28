/*
Faça um programa que pergunte para o usuário a quantidade de números que ele
quer digitar. Após isso crie um laço que exiba o número que o usuário digitar apenas
se for PAR. Utilize a estrutura WHILE.

*/


//perguntar quantos números o usuário quer digitar
//criar um laço while baseado na quantidade de números que o usuário quer digitar
//dentro do laço, verificar se é par e imprimir $"Número digitado é par: {nDigitado}"
int q = 0, i = 1, n = 1;

Console.WriteLine("Quantos numeros voce deseja digitar?");
q = int.Parse(Console.ReadLine());

while (n <= q)
{
    Console.WriteLine("Digite um numero");
    i = int.Parse(Console.ReadLine());
    if (i % 2 == 0)
    {
        Console.WriteLine($"O numero digitado é par: {i}");
    }
    n++;
}