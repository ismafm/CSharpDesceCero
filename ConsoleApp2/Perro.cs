using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Perro : Animal
    {
        public string Raza {  get; set; }
        public override string SonidoAnimal()
        {
            return "Guau!";
        }

        public Perro(string nombre,string raza) 
        {
            this.Nombre = nombre;
            this.Raza = raza;
        }
    }
}
