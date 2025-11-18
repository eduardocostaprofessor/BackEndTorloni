// using System.Data;
// using ClassesEObjetos;
// Console.Clear();
// Pessoa joao = new Pessoa();

// joao.Nome = "João Silva";
// Console.WriteLine($"{joao.Nome} tem {joao.Idade} anos");
// //0

// int novaIdade = joao.Envelhecer(17);//atualiza e devolve a idade
// Console.WriteLine($"{joao.Nome} tem {novaIdade} anos");
// //17
// novaIdade = joao.Envelhecer(-50);//devolva a idade antiga: 17
// Console.WriteLine($"{joao.Nome} tem {joao.Idade} anos");

using ClassesEObjetos;

Console.WriteLine($"-- Agência Bancária --");
Console.WriteLine($"Digite o nome do titular da conta: ");
string nomeT = Console.ReadLine();

AgenciaBancaria conta = new AgenciaBancaria(nomeT);

Console.WriteLine();
Console.WriteLine($"Bem vindo, {conta.Titular}");
Console.WriteLine($"Saldo inicial: R$ {conta.Saldo:F2}");
Console.WriteLine();

int opcao = 0;
do
{
    Console.WriteLine($"\n Menu");
    Console.WriteLine($"1 - Depositar");
    Console.WriteLine($"2 - Sacar");
    Console.WriteLine($"0 - Sair");
    Console.WriteLine($"Escolha uma opção: ");
    opcao = int.Parse(Console.ReadLine());

    Console.WriteLine();

    switch (opcao)
    {
        case 1:
            Console.WriteLine($"Digite o valor do depósito: R$");
            double deposito = Convert.ToDouble(Console.ReadLine());
            conta.Depositar(deposito);
            break;

        case 2:
            Console.WriteLine($"Digite o valor de saque: R$ ");
            double saque = Convert.ToDouble(Console.ReadLine());
            conta.Sacar(saque);
            break;

        case 0:
            Console.WriteLine($"Saindo.");
            break;

        default:
            Console.WriteLine($"Opção inválida, escolhe uma das opções acima.");

            break;
    }
} while (opcao != 0);