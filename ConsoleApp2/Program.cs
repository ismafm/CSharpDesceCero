using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ConsoleApp2
{
    internal class Program
    {

        static void VariablesSimples()
        {
            //VARIABLES

            // Tipos enteros
            byte aByte = 255;      // 8 bits, sin signo
            int aInt = 1000;       // 32 bits, con signo
            long aLong = 1000000L;  // 64 bits, con signo

            // Tipos de punto flotante
            float aFloat = 3.14f;  // 32 bits, precisión simple
            double aDouble = 3.14159;  // 64 bits, precisión doble
            decimal aDecimal = 19.99m;  // 128 bits, alta precisión (financiero)

            // Tipos de texto
            char aChar = 'A';      // Un solo carácter
            string aString = "Hola Mundo";  // Cadena de texto

            // Tipo lógico
            bool esVerdadero = true;  // Valor lógico (true/false)

            // Mostrar los valores
            Console.WriteLine($"byte: {aByte}");
            Console.WriteLine($"int: {aInt}");
            Console.WriteLine($"long: {aLong}");
            Console.WriteLine($"float: {aFloat}");
            Console.WriteLine($"double: {aDouble}");
            Console.WriteLine($"decimal: {aDecimal}");
            Console.WriteLine($"char: {aChar}");
            Console.WriteLine($"string: {aString}");
            Console.WriteLine($"bool: {esVerdadero}");
        }

        static void ArreglosYListas()
        {

            // Declaración e inicialización de un arreglo
            //int[] numeros = new int[5] { 1, 2, 3, 4, 5 };

            //// Acceder a los elementos del arreglo
            //Console.WriteLine($"Primer número: {numeros[0]}");
            //Console.WriteLine($"Último número: {numeros[4]}");
            //Console.WriteLine("\n");
            // Declaración e inicialización de una lista
            List<string> nombres = new List<string> { "Juan", "Jorge", "Ana", "Pedro" };

            // Agregar un elemento a la lista
            nombres.Add("Maria");
            Console.WriteLine($"Lista de nombres completa:");

            foreach (var nombre in nombres)
            {
                Console.WriteLine(nombre);
            }

            Console.WriteLine("\n");
            //Se puede filtrar una lista para encontrar el nombre que quieres
            List<string> nombreConJ = nombres.Where(n => n.StartsWith("J")).ToList();

            Console.WriteLine("\n");
            Console.WriteLine($"Nombre encontrado: {nombreConJ}");

            Console.WriteLine($"Lista de nombres sin Maria:");
            // Mostrar todos los elementos
            foreach (var nombre in nombres)
            {
                Console.WriteLine(nombre);
            }
            //Los arreglos son estructuras de datos fijas que pueden almacenar elementos del mismo tipo.
            //Las listas son colecciones
            //dinámicas que pueden crecer o reducir su tamaño durante la ejecución del programa.

        }

        static void ValidarDatosEspañol()
        {

            Console.Write("Nombre de la persona\n");
            string nombre = Console.ReadLine();
            Console.Write("Primer apellido de la persona\n");
            string primerApellido = Console.ReadLine();
            Console.Write("Segundo apellido de la persona\n");
            string segundoApellido = Console.ReadLine();
            Console.Write("DNI de la persona\n");
            string dni = Console.ReadLine();
            Console.Write("La persona tiene vivienda (escriba 'SÍ' si tiene o 'NO' si no tiene)\n");
            string tieneViviendaTexto = Console.ReadLine();
            bool tieneVivienda;
            if(tieneViviendaTexto.ToLower() == "sí" || tieneViviendaTexto.ToLower() == "si")
            {
                tieneVivienda = true;
            }
            else
            {
                tieneVivienda = false;
            }
            Console.Write("Dirección de la persona");
            string direccion = Console.ReadLine();
            
            Console.Write("Edad de la persona");
            int edad = int.Parse(Console.ReadLine());

            Español ciudadanoEspañol = new Español(nombre,primerApellido,segundoApellido,dni,
                tieneVivienda,direccion, edad);

            Console.WriteLine(ciudadanoEspañol.DniValido() == true ? "Tiene un dni válido" : "No tiene un dni válido");
        }
        static void Condicionales()
        {
            //int numero = 5;
            //bool esPar = (numero % 2) == 0;
            //if (esPar)
            //{
            //    Console.WriteLine($"El número {numero} es par");
            //}else if (!esPar)
            //{
            //    Console.WriteLine($"El número {numero} es impar");
            //}

            ////Operadores ternarios
            //Console.WriteLine( numero % 2 == 0 ? $"El número {numero} es par" : $"El número {numero} es impar");
            //SWITCH CASE

            string diaSemana = "Saábado";

            switch (diaSemana)
            {
                case "Lunes":
                    Console.WriteLine("Acabas de empezar la semana, te quedan 4 días para acabarla");
                    break;
                case "Martes":
                    Console.WriteLine("Segundo día de la semana, te quedan 3 días para acabarla");
                    break;
                case "Miércoles":
                    Console.WriteLine("Tercer día de la semana, te quedan 2 días para acabarla");
                    break;
                case "Jueves":
                    Console.WriteLine("Cuarto día de la semana, te quedan 1 días para acabarla");
                    break;
                case "Viernes":
                    Console.WriteLine("Último día, estás a nada del fin de semana");
                    break;
                case "Sábado":
                case "Domingo":
                    Console.WriteLine("Llegaste al fin de semana");
                    break;
                default:
                    Console.WriteLine("No se ha encontrado el día de la semana");
                    break;
            }

        }
        static void Operadores()
        {
            // Operadores Aritméticos
            Console.WriteLine("=== Operadores Aritméticos ===");
            int a = 10, b = 3;

            // Suma
            int suma = a + b; // Suma de 10 y 3
            Console.WriteLine($"Suma: {a} + {b} = {suma}");

            // Resta
            int resta = a - b; // Resta de 10 menos 3
            Console.WriteLine($"Resta: {a} - {b} = {resta}");

            // Multiplicación
            int multiplicacion = a * b; // Multiplica 10 por 3
            Console.WriteLine($"Multiplicación: {a} * {b} = {multiplicacion}");

            // División
            int division = a / b; // Divide 10 entre 3 (resultado entero)
            Console.WriteLine($"División: {a} / {b} = {division}");

            // Módulo
            int modulo = a % b; // Resto de la división de 10 entre 3
            Console.WriteLine($"Módulo: {a} % {b} = {modulo}");

            Console.WriteLine();

            // Operadores de Asignación
            Console.WriteLine("=== Operadores de Asignación ===");
            int x = 5;
            
            // Asignación directa
            x = 10; // Asigna 10 a x
            Console.WriteLine($"Asignación: x = {x}");

            // Suma y asignación
            x += 3; // Equivale a x = x + 3
            Console.WriteLine($"Suma y asignación: x += 3 -> x = {x}");

            // Resta y asignación
            x -= 2; // Equivale a x = x - 2
            Console.WriteLine($"Resta y asignación: x -= 2 -> x = {x}");

            // Multiplicación y asignación
            x *= 4; // Equivale a x = x * 4
            Console.WriteLine($"Multiplicación y asignación: x *= 4 -> x = {x}");

            // División y asignación
            x /= 3; // Equivale a x = x / 3
            Console.WriteLine($"División y asignación: x /= 3 -> x = {x}");

            // Módulo y asignación
            x %= 2; // Equivale a x = x % 2
            Console.WriteLine($"Módulo y asignación: x %= 2 -> x = {x}");

            Console.WriteLine();

            // Operadores de Comparación
            Console.WriteLine("=== Operadores de Comparación ===");
            int y = 7;

            // Igualdad
            Console.WriteLine($"Igualdad: {a} == {y} -> {a == y}");

            // Diferente
            Console.WriteLine($"Diferente: {a} != {y} -> {a != y}");

            // Mayor que
            Console.WriteLine($"Mayor que: {a} > {y} -> {a > y}");

            // Menor que
            Console.WriteLine($"Menor que: {a} < {y} -> {a < y}");

            // Mayor o igual
            Console.WriteLine($"Mayor o igual: {a} >= {y} -> {a >= y}");

            // Menor o igual
            Console.WriteLine($"Menor o igual: {a} <= {y} -> {a <= y}");

            Console.WriteLine();

            // Operadores Lógicos
            Console.WriteLine("=== Operadores Lógicos ===");
            bool cond1 = true, cond2 = false;

            // AND lógico
            Console.WriteLine($"AND lógico: {cond1} && {cond2} -> {cond1 && cond2}");

            // OR lógico
            Console.WriteLine($"OR lógico: {cond1} || {cond2} -> {cond1 || cond2}");

            // NOT lógico
            Console.WriteLine($"NOT lógico: !{cond1} -> {!cond1}");

            Console.WriteLine();

            // Operadores de Incremento y Decremento
            Console.WriteLine("=== Operadores de Incremento y Decremento ===");
            int z = 5;

            // Incremento posterior
            Console.WriteLine($"Incremento posterior: z++ -> z antes: {z}, z después: {z++}");

            // Incremento anterior
            z = 5; // Reseteamos z
            Console.WriteLine($"Incremento anterior: ++z -> z antes: {z}, z después: {++z}");

            // Decremento posterior
            z = 5; // Reseteamos z
            Console.WriteLine($"Decremento posterior: z-- -> z antes: {z}, z después: {z--}");

            // Decremento anterior
            z = 5; // Reseteamos z
            Console.WriteLine($"Decremento anterior: --z -> z antes: {z}, z después: {--z}");

            Console.WriteLine();

            // Operadores de Bits
            //Console.WriteLine("=== Operadores de Bits ===");
            //int p = 5, q = 3; // 5 = 0101, 3 = 0011 en binario

            //// AND binario
            //Console.WriteLine($"AND binario: {p} & {q} -> {p & q}");

            //// OR binario
            //Console.WriteLine($"OR binario: {p} | {q} -> {p | q}");

            //// XOR binario
            //Console.WriteLine($"XOR binario: {p} ^ {q} -> {p ^ q}");

            //// Complemento
            //Console.WriteLine($"Complemento: ~{p} -> {~p}");

            //// Desplazamiento a la izquierda
            //Console.WriteLine($"Desplazamiento a la izquierda: {p} << 1 -> {p << 1}");

            //// Desplazamiento a la derecha
            //Console.WriteLine($"Desplazamiento a la derecha: {p} >> 1 -> {p >> 1}");
        }
        static void Bucles()
        {
            //int[] array = { 1, 2, 3, 4, 5 };

            //for(int i = 0; i<array.Length; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}
            //Console.WriteLine();
            //foreach(int num in array)
            //{
            //    Console.WriteLine(num);
            //}
            string contenido = "";
            while (contenido == "")
            {
                Console.Write("Escribe lo que quieras para finalizar el bucle");
                contenido = (Console.ReadLine()).Trim();
            }
        }
        static void NumerosAleatorios()
        {
            Random random = new Random();
            //Números enteros
            int numeroMaximo = 23;

            int numeroGenerado1 = random.Next(numeroMaximo);
            Console.WriteLine($"El número generado {numeroGenerado1} " +
                $"se situa entre los números 0 y {numeroMaximo - 1}");


            int numeroMinimo = 8;
            int numeroGenerado2 = random.Next(numeroMinimo, numeroMaximo);
            Console.WriteLine($"El número generado {numeroGenerado2} " +
                $"se situa entre los números {numeroMinimo} y {numeroMaximo - 1}");

            //Números con decimales
            //double numeroMaximoDouble = 23.5;

            //double numeroGenerado1Double = Math.Round(random.NextDouble() * numeroMaximoDouble, 2);
            //Console.WriteLine($"El número generado {numeroGenerado1Double} " +
            //    $"se situa entre los números 0 y {numeroMaximoDouble}. Sin incluir este último");


            //double numeroMinimoDouble = 8;
            //double numeroGenerado2Double = Math.Round(numeroMinimoDouble + 
            //    (random.NextDouble() * (numeroMaximoDouble - numeroMinimoDouble)),2);
            //Console.WriteLine($"El número generado {numeroGenerado2Double} " +
            //    $"se situa entre los números {numeroMinimoDouble} y {numeroMaximoDouble}. Sin incluir este último");
        }
        static void Polimorfismo()
        {
            Perro perro = new Perro("Robby", "Pastor alemán");
            Console.WriteLine($"Tu nuevo perro {perro.Nombre} te dice '{perro.SonidoAnimal()}'");

            Gato gato = new Gato("Angel", true);
            if (gato.EsArisco)
            {
                Console.WriteLine($"Que mal. tu gato {gato.Nombre} ha resultado muy arisco :(");
            }
            else
            {
                Console.WriteLine($"¡Felicidades, Tu nuevo gato ha resultado ser muy bueno!");
            }
        }
        static void Main(string[] args)
        {

            //VariablesSimples();
            //ArreglosYListas();
            //Condicionales();
            //ValidarDatosEspañol();
            //Operadores();
            //Bucles();
            //NumerosAleatorios();
            Polimorfismo();





        }
    }
}
