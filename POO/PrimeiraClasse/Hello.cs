
using System.Runtime.InteropServices.Marshalling;

namespace PrimeiraClasse
{
    public class Hello
    {
        // Propriedades/Características - variáveis internas dessa classe
        public string TextoHello = "";

        // Métodos/Comportamentos/Açõers - são as funções internas dessa classe 
        public void SaldarUsuario()
        {
            Console.WriteLine(this.TextoHello);
        }

        public void SaldarComNome(string n)
        {
            Console.WriteLine($"Olá {n}");
        }
    }//fim da classe
}// fim do namespace