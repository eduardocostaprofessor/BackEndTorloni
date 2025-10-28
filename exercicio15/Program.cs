// Faça um programa que receba 4 notas de um aluno, calcule e imprima a média
// aritmética das notas e a mensagem de APROVADO para média superior ou igual a
// 7,0 RECUPERAÇÃO para notas entre 5.0 e 7,0 ou a mensagem de REPROVADO
// para média inferior a 5,0.



double nota1, nota2, nota3, nota4, media;

Console.WriteLine("Digite a primeira nota:");
nota1 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a segunda nota:");
nota2 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a terceira nota:");
nota3 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a quarta nota:");
nota4 = double.Parse(Console.ReadLine());

media = (nota1 + nota2 + nota3 + nota4) / 4;
Console.Write($"Média: {media}, ");

if (media >= 7)
{
    Console.WriteLine("Aprovado");
}

else if (media >= 5)
{
    Console.WriteLine("Recuperacao");
}

else
{
    Console.WriteLine("Reprovado");
}

