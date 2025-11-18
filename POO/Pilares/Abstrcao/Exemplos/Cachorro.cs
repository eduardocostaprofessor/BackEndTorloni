namespace Exemplos
{
    public class Cachorro : Animal
    {
        public override void FazerSom()
        {
            Console.WriteLine($"Au Au");
            
        }

        public override void Mover()
        {
            Console.WriteLine($"Ploc Ploc Ploc");
            
        }
    }
}