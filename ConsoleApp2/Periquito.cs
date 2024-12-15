using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Periquito : Animal
    {
        public override string SonidoAnimal()
        {
            return "Pio";
        }

        public override int NumeroPatas()
        {
            return 2;
        }
        public Periquito(string nombre) 
        {
            this.Nombre = nombre;
        }
    }
}
