using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    /*
     Tipos de accesibilidad en clases:
     Public: accesible desde otros proyectos
     Internal: accesible desde un mismo proyecto
     */
    public class Persona : IMamifero
    {
        /*
        Tipos de accesibilidad en los parametros:
        Public: accesible desde cualquier punto
        Protected: accesible solo desde su clase y la de sus hijos
        Private: accesible únicamente desde la misma clase
        */
        public string Nombre { get; set; }
        public int Edad {  get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }

        public void TipoMamifero()
        {
            Console.WriteLine("Es un humano");
        }
        
    }
}
