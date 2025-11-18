using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PrimeiraClasse
{
    public class Garrafa
    {
        public int litragem;

        public Garrafa()
        {
            
        }
        public Garrafa(int _litragemMl)
        {
            
        }

        public void Abrir()
        {
            Console.WriteLine($"Pluk, Garrafa Abrindo!");
            
        }
    }
}