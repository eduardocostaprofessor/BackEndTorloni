using System.Dynamic;

namespace Encapsulamento
{
    public class Carro
    {
        private string Marca;        
        private string Modelo;        
        private int VelocidadeAtual;


        // Gest e Sets
        

        // Set Marca
        public void DefinirMarca(string valor)
        {
            Marca = valor;
        }

        // GetI da marca
        public string ObterMarca()
        {
            return Marca;
        }


        // Set da Modelo
        public void DefinirModelo(string valor)
        {
            Modelo = valor;
        }

        // Get da Modelo
        public string ObterModelo()
        {
            return Modelo;
        }

        // Get da Velocidade
        public int ObterVelocidade()
        {
            return VelocidadeAtual;
        }

        // Set da Velocidade
        public void Acelera(int valor)
        {
            if(valor > 0) 
                VelocidadeAtual += valor;
        }

        public void Frear(int valor)
        {
            if(valor > 0) 
                VelocidadeAtual -= valor;
            
        }
    }
}