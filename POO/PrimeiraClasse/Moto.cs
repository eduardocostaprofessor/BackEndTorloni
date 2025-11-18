
namespace PrimeiraClasse
{
    public class Moto
    {
        // Propriedades
        public string Cor;
        public string Modelo;
        public int qtdRodas;
        public string Marca;

        // Métodos
        public void Ligar()
        {
            Console.WriteLine($"Vrum, Vrum ...");
        }
        public void Desligar()
        {
            Console.WriteLine($"Desligando a moto");
        }
        public void Acelerar()
        {
            Console.WriteLine($"Vruuuuuuuummm tu tu tu tu tu tu");
        }
    }
}