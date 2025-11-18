namespace Exercicio01
{
    public class Carro : Veiculo
    {
        // Sobrescrita do método Acelerar
        public override void Acelerar()
        {
            Console.WriteLine($"Vrum Vrum");
            
        }
    }
}