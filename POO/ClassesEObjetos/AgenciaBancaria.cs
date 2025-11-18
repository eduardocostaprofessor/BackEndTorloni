namespace ClassesEObjetos
{
    public class AgenciaBancaria
    {
        //Propriedades
        public string Titular;

        public double Saldo;

        
        public AgenciaBancaria(string titular, double saldoInicial = 0)
        {
            Titular = titular;
            Saldo = saldoInicial;
        }

        //Métodos
        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
                Console.WriteLine($"Depósito no valor de R$ {valor:F2} realizado");
            }
            else
            {
                Console.WriteLine($"O valor depositado deve ser maior que 0.");
            }
            Console.WriteLine($"Saldo atual: R$ {Saldo:F2}");
        }
        
        public void Sacar(double valor)
        {
            if (valor > 0 && valor <= Saldo)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque no valor de R$ {Saldo:F2} realizado");
            }
            else if (valor > Saldo)
            {
                Console.WriteLine($"Saldo insuficiente");
            }
            else
            {
                Console.WriteLine($"O valor do saque deve ser maior que 0.");
            }
            Console.WriteLine($"Saldo atual: R$ {Saldo:F2}");
        }
    }
}