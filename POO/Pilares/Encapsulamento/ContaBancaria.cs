
namespace Encapsulamento
{
    public class ContaBancaria
    {
        private float Saldo;
        
        // Construtores
        public ContaBancaria()
        {
            Saldo = 0;
        }

        public ContaBancaria(float saldoInicial)
        {
            if (saldoInicial > 0)
            {
                Saldo = saldoInicial;
            }
        }

        // Método público que seta/configura/guarda o Saldo
        public void Depositar(float valor)
        {
            if (valor >= 0)
            {
                Saldo = valor;
                return;
            }

            Console.WriteLine($"Valor para depósito inválido");
            
        }

        // Método público que retorna o Saldo
        public float GetSaldo()
        {
            return Saldo;
        }

        // crie o método público Sacar(float valor)

        public void Saque(float valor)
        {
            if (valor >= 0 && valor <= Saldo)
            {
                Saldo -= valor;
                System.Console.WriteLine("saque efetuado com sucesso!");
                return;
            }

            Console.WriteLine($"Valor para saque inválido");
            
        }
    }
}