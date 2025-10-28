/*
Pedir o nome do usuário, 
Pedir dois números e 
mostrar a soma dos números no final
*/

string nome;
int numero1;
int numero2;

// pedir os nome pro usuário
Console.WriteLine("Digite seu nome");
nome = Console.ReadLine(); //pede o nome do usuário

//pedir os dois números
Console.WriteLine("Digite o primeiro número");
numero1 = int.Parse(Console.ReadLine());//converte o texto em número
Console.WriteLine("Digite o segundo número");
numero2 = int.Parse(Console.ReadLine());//converte o texto em número

//somar os dois números
int soma = numero1 + numero2;

// exibir nome e a soma 
Console.WriteLine(nome); //exibe o nome do usuário
Console.WriteLine(soma); //exibe o o total da soma
