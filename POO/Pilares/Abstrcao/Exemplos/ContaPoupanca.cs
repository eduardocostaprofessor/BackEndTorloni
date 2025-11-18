namespace Exemplos
{
    public class ContaPoupanca : ContaBancaria
    {
        public double Saldo;
        private double Taxa = 0.03;//3% de taxa
        public override void Depositar(double valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine($"O valor do depósito deve ser maior que R$0,00");
                return;// para a execução do método por aqui
            }

            Saldo += valor;
        }

        public override void Sacar(double valor)
        {//na classe ContaPoupanca aplicar a taxa de 3% no saque

            //          valor solicitado + taxa de x%
            double totalComTaxa = valor + (valor * Taxa);

            if (valor <= 0 || totalComTaxa >= Saldo)
            {//Não tem dinheiro na conta
                Console.WriteLine($"O valor do saque deve positivo e ter dinheiro suficienta para o saque (Conta Corrente)");
                return;// para a execução do método por aqui
            }

            // Calcular o saque + taxa de saque
            Saldo -= totalComTaxa;
        }
    }
}