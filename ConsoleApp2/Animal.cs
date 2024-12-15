using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal abstract class Animal
    {
        public string Nombre { get; set; }
        public abstract string SonidoAnimal();

        public virtual int NumeroPatas()
        {
            return 4;
        }

    }
}
