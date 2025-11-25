using System.Security.Cryptography.X509Certificates;

namespace Exercicio01
{
    public class Circulo : IForma
    {
        public float Raio;
        private float PI = 3.14f;
        public void CalcularArea()
        {
            Console.WriteLine($"A área do círculo é {PI * Raio * Raio}");
        }
    }
}