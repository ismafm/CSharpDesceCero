using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Perro : Animal, IMamifero
    {
        public string Raza {  get; set; }
        public override string SonidoAnimal()
        {
            return "Guau!";
        }

        public void TipoMamifero()
        {
            Console.WriteLine("El animal es un perro");
        }

        public Perro(string nombre,string raza) 
        {
            this.Nombre = nombre;
            this.Raza = raza;
        }
    }
}
