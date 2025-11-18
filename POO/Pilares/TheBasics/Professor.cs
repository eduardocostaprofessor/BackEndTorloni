
namespace TheBasics
{
    public class Professor : Pessoa
    {
        public float Salario;

        // Chama o construtor da classe mãe e repassa o endereço pra lá
        public Professor(Endereco endereco) : base(endereco)
        {

        }
    }
}