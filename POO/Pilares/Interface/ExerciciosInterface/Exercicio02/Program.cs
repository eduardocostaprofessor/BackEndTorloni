using Exercicio02;

// Cria uma lista de objetos Fatura
List<IImprimivel> documentos = new List<IImprimivel>();

int opcao;
do
{
    Console.Clear();
    // Desenha io Menu
    Console.WriteLine($"Menu de Opções");
    Console.WriteLine($@"
1) Cadastrar Fatura
2) Cadastrar Relatório
3) Cadastrar Contrato
4) Listar Faturas
5) Listar Relatórios
6) Listar Contratos
0) Sair
Escolha a opção:");
    opcao = int.Parse(Console.ReadLine());


    switch (opcao)
    {
        case 1:
            Console.WriteLine($"Cadastrar Fatura");
            break;
        case 2:
            Console.WriteLine($"Cadastrar Relatório");
            break;
        case 3:
            Console.WriteLine($"Cadastrar Contrato");
            break;
        case 4:
            Console.WriteLine($"Listar Faturas");
            break;
        case 5:
            Console.WriteLine($"Listar Relatórios");
            break;
        case 6:
            Console.WriteLine($"Listar Contratos");
            break;
        case 0:
            Console.WriteLine($"Sair");
            break;
        default:
            Console.WriteLine($"Opção invlálida");
            break;
    }

    Console.WriteLine($"Digite <Enter> para continuar ...");
    Console.ReadLine();//Para o console para dar tempo de ver as mensagens do programa

} while (opcao != 0);



//  Funções Auxiliares

void CadastrarFatura()
{
    // Pede os dados para o usuário
    Console.Write($"Digite o nome do devedor: ");
    string dev = Console.ReadLine();
    Console.Write($"Digite o nome do credor: ");
    string cred = Console.ReadLine();
    Console.Write($"Digite o valor da fatura: ");
    float valor = float.Parse(Console.ReadLine());
    Console.Write($"Quantos dias a fatura está em atraso? ");
    int diasAtraso = int.Parse(Console.ReadLine());

    // cria o objeto da fatura
    Fatura f = new Fatura(dev, cred, valor, diasAtraso);
    // cadastra a fatura na lista
    documentos.Add(f);
}

void CadastrarContrato()
{
    Console.Write($"Digite o nome do Contratante: ");
    string contratante = Console.ReadLine();
    Console.Write($"Digite o nome do Empresa Contratada: ");
    string contratada = Console.ReadLine();

    Console.Write($"Digite as cláusulas do contrato: ");
    string txtClausulas = Console.ReadLine();

    Contrato ojbContrato = new Contrato(contratante, contratada, txtClausulas);
    documentos.Add(ojbContrato);
    Console.WriteLine($"Contrato cadastrado com sucesso");
}

void CadastrarRelatorio()
{
    Console.Write($"Digite o nome responsável pelo relatório: ");
    string resp = Console.ReadLine();
    Console.Write($"Digite o texto do relatório: ");
    string txt = Console.ReadLine();

    Relatorio relatorio = new Relatorio(resp, txt);
    documentos.Add(relatorio);

    Console.WriteLine($"Relatório cadastrado com sucesso");

}


void ListarFaturas()
{
    Console.WriteLine($"Listando as faturas: ");
    foreach (var item in documentos)
    {
        if (item is Fatura)
        {//valida o tipo da classe e imprime só se for fatura
            item.Imprimir();
        }
    }

}

void ListarContratos()
{
    Console.WriteLine($"Listando os Contratos: ");
    foreach (var item in documentos)
    {
        if (item is Contrato)
        {//valida o tipo da classe e imprime só se for Contrato
            item.Imprimir();
        }
    }
}

void ListartRelatorios()
{
    Console.WriteLine($"Listando os Relatórios: ");
    foreach (var item in documentos)
    {//valida o tipo da classe e imprime só se for Relatório
        if (item is Relatorio)
        {
            item.Imprimir();
        }
    }
}