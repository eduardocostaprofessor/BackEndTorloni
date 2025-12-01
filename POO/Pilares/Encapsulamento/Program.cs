using Encapsulamento;

// float dinheiro = 200;

// ContaBancaria contaEdu = new ContaBancaria();
// ContaBancaria contaMaria = new ContaBancaria(dinheiro);

// contaEdu.Depositar(dinheiro);

// Console.WriteLine($"Saldo do Edu: R${contaEdu.GetSaldo()}");
// Console.WriteLine($"Saldo do Maria: R${contaMaria.GetSaldo()}");

// contaEdu.Saque(100);
// Console.WriteLine($"Saldo apos saque do Edu: R${contaEdu.GetSaldo()}");


// No método Main, crie um objeto da classe Carro, defina sua marca e modelo usando os métodos criados, acelere e freie algumas vezes.

// Após as operações, mostre na tela a marca, o modelo e a velocidade atual do carro usando os métodos de leitura.

Console.Clear();
Carro fusca = new Carro();

fusca.DefinirMarca("VolksWagen");
fusca.DefinirModelo("Fusca 89");

fusca.Acelera(100);
fusca.Acelera(50);

fusca.Frear(10);

Console.WriteLine($"Marca: {fusca.ObterMarca()}");
Console.WriteLine($"Modelo: {fusca.ObterModelo()}");
Console.WriteLine($"Velocidade Atual: {fusca.ObterVelocidade()}");

