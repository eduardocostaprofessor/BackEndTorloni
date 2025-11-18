

namespace TheBasics
{
    public class Veiculo
    {
        public string Marca;
        public string Modelo;
        public int QtdRodas;
        public void Ligar()
        {
            Console.WriteLine($"Ligando o veículo");
        }
        public void Desligar()
        {
            Console.WriteLine($"Veículo desligado");
        }

    }
}