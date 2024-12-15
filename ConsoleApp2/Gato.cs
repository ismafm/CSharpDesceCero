using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Gato : Animal
    {
        public bool EsArisco {  get; set; }

        public override string SonidoAnimal()
        {
            return "Miau";
        }

        public Gato(string nombre, bool esArisco) 
        {
            this.Nombre = nombre;
            this.EsArisco = esArisco;
        }
    }
}
