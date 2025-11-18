namespace Exercicio01
{
    public class Veiculo
    {
        public string Marca;
        public string Modelo;
        public int Ano;

    // Permite o método ser sobrescrito
        public virtual void Acelerar()
        {
            Console.WriteLine($"Acelerando o Veículo");
            
        }
    }
}