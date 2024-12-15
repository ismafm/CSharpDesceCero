using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Español : Persona
    {
        public string Dni { get; set; }
        public bool TieneVivienda {  get; set; }
        public string Direccion { get; set; }

        public bool DniValido()
        {
            // El DNI debe tener 9 caracteres: 8 dígitos seguidos de una letra
            if (string.IsNullOrWhiteSpace(this.Dni) || this.Dni.Length != 9)
            {
                return false;
            }

            // Verificamos que los primeros 8 caracteres sean dígitos y el noveno sea una letra
            string numeros = this.Dni.Substring(0, 8);
            char letra = this.Dni[8];

            if (!long.TryParse(numeros, out long dniNumerico))
            {
                return false; // Si los primeros 8 caracteres no son numéricos, no es válido
            }

            // La letra debe ser válida según el algoritmo
            string letrasValidas = "TRWAGMYFPDXBNJZSQVHLCKE"; // Letras correspondientes a cada resto de 23
            int indice = (int)(dniNumerico % 23); // Cálculo del índice en el conjunto de letras

            // Comprobamos si la letra del DNI es la correcta
            char letraEsperada = letrasValidas[indice];

            return char.ToUpper(letra) == letraEsperada;
        }

        public Español(string nombre, string primerApellido, string segundoApellido,
            string dni, bool tieneVivienda, string direccion,int edad)
        {
            this.Nombre = nombre;
            this.PrimerApellido = primerApellido;
            this.SegundoApellido = segundoApellido;
            this.Dni = dni;
            this.TieneVivienda = tieneVivienda;
            this.Direccion = direccion;
            this.Edad = edad;

        }
    }
}
