using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Periquito : Animal, IMamifero
    {
        public override string SonidoAnimal()
        {
            return "Pio";
        }

        public void TipoMamifero()
        {
            Console.WriteLine("El animal es un periquito");
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
