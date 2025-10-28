Console.Clear();//limpa tela

int opcao = -1;

do
{//todo o programa aqui dentro
 //desenha um menu de opções
    Console.WriteLine("Escolha uma opção no menu abaixo:");
    Console.WriteLine(" 1 - Exercício 01");
    Console.WriteLine(" 2 - Exercício 02");
    Console.WriteLine(" 3 - Exercício 03");
    Console.WriteLine(" 4 - Exercício 04");
    Console.WriteLine(" 0 - Sair");
    //captura a opção do usuário
    opcao = int.Parse(Console.ReadLine());

    //escolhe a opção indicada pelo usuário
    switch (opcao)
    {
        case 1:
            Exercicio01();
            break;
        case 2:
            Exercicio02();
            break;
        case 3:
            Exercicio03();
            break;

        case 4:
            Exercicio04();
            break;
        case 0:
            Console.WriteLine($"Você escolheu sair - Obrigado por usar o programa");
            break;
        default:
            Console.WriteLine($"Não temos esta opção {opcao} !!");
            break;
    }

} while (opcao != 0);

Console.Clear();
Console.WriteLine($"FIM DO PROGRAMA");



void Exercicio01()
{
    Console.WriteLine($"Colar o código do exercício 01 aqui");
    
}
void Exercicio02()
{
    Console.WriteLine($"Colar o código do exercício 02 aqui");
    
}
void Exercicio03()
{
    Console.WriteLine($"Colar o código do exercício 03 aqui");
    
}
void Exercicio04()
{
    Console.WriteLine($"Colar o código do exercício 04 aqui");
    
}