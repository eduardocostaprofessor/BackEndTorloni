using System.Runtime.InteropServices;
using Exemplos;
// 1. Classe Animal
// Crie uma classe abstrata chamada Animal com os métodos FazerSom() e Mover().
// Crie duas classes derivadas: Cachorro e Gato. Cada uma deve implementar os métodos de forma diferente.

// Cachorro toto = new Cachorro();
// Gato gatinho = new Gato();
// Aluno edu = new Aluno();

// 2. Classe ContaBancaria
// Crie uma classe abstrata ContaBancaria com os métodos Depositar(double valor) e Sacar(double valor).
// Crie duas classes: ContaCorrente e ContaPoupanca, cada uma com sua própria forma de calcular o saldo após saque (por exemplo, taxa diferente).

Console.Clear();
ContaCorrente cc = new ContaCorrente();
ContaPoupanca cp = new ContaPoupanca();

cc.Depositar(10);
cp.Depositar(10);

Console.WriteLine($"Saldo Conta Corrente antes do Saque: R${cc.Saldo}");
Console.WriteLine($"Saldo Conta Poupança antes do Saque: R${cp.Saldo}");
cc.Sacar(10);
cp.Sacar(5);

Console.WriteLine();

Console.WriteLine($"Saldo Conta Corrente após o saque: R${cc.Saldo}");
Console.WriteLine($"Saldo Poupança após o saque: R${cp.Saldo}");


