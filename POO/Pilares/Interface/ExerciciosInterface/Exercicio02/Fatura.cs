using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Exercicio02
{
    public class Fatura : IImprimivel
    {
        public string Devedor = "";
        public string Credor = "";
        public float Valor = 0;
        public int DiasDeAtraso = 0;
        private float Juros = 0.10f;

        // Sobrecarga do Construtor - obriga a passar os dados na criação do objeto
        public Fatura( string dev, string cred, float valFat, int qtdAtraso )
        {
            Devedor = dev;
            Credor = cred;
            DiasDeAtraso = qtdAtraso;
            Valor = valFat;
        }

        public void Imprimir()
        {
            // Calcular o Júros antes de usar o valor da Fatura
            CalcularValorDivida();

            Console.WriteLine($@"
    Credor: {Credor} 
    Devedor: {Devedor} 
    Dias de atraso: {DiasDeAtraso} dia(s)
    Valor: R${Valor:F2}
    Júros: R${(Juros * DiasDeAtraso):F2}
    Total Com Júros: R${Valor:F2}
            ");//já pula uma linha
        }

        public void CalcularValorDivida()
        {
            if(DiasDeAtraso > 0 )
            {
                Valor = Valor + DiasDeAtraso * Juros;
            } 

            if(DiasDeAtraso >= 5)
            {
                Console.WriteLine($"Dívida encaminhada para o SERASA");
            }
        }
    }
}