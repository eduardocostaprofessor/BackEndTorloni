namespace ClassesEstaticas
{
    public static class CalculosMatematicos
    {
        // Operações Matemáticas simples
        // visibilidade tipoDeRetorno Nome(parâmetros){corpo}
        public static float Somar(float a, float b)
        {
             return a + b;
        }
        
        public static float Subtrair(float a, float b)
        {
             return a - b;
        }

        public static float Multiplicar(float a, float b)
        {
             return a * b;
        }
        public static float Dividir(float a, float b)
        {
            if(b == 0)
            {
                Console.WriteLine($"Divisão Inválida");
            }

             return a / b;
        }

        // Criar as outras 3 operações
        // Não se esqueça que não existe divisão por zero, então na divisão faça a validação
    }
}