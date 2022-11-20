using System;
using System.Collections.Generic;
using static System.Environment;

namespace Consola
{
    class Program
    {
        public delegate int DelegadoComparacion(string primerTexto, string segundoTexto);

        static void Main(string[] args)
        {
            // Borrar o agregar la primera barra para switchear entre las pruebas fijas y el ingreso de texto por consola. 
            //*
            string primerTexto = "Vive como si fueras a morir mañana; aprende como si el mundo fuera a durar para siempre.";
            // Cant. caracteres: 88, Cant. palabras: 17 , Cant. vocales: 34, Cant. signos puntuación: 2 
            string segundoTexto = "La vida es como montar en bicicleta; para mantener el equilibrio debes seguir moviéndote.";
            // Cant. caracteres: 89, Cant. palabras: 13, Cant. vocales: 35, Cant. signos puntuación: 2

            /*/
            Console.WriteLine("Ingrese el primer texto:");
            string primerTexto = Console.ReadLine();

            Console.WriteLine("Ingrese el segundo texto:");
            string segundoTexto = Console.ReadLine();
            //*/

            Console.WriteLine($"{NewLine}1era Comparación - Texto con más caracteres:");
            Comparar((t1, t2) => t1.Length - t2.Length, primerTexto, segundoTexto);
            // Punto 2
            Console.WriteLine($"{NewLine}2da Comparación - Texto con más palabras:");
            Comparar((t1, t2) => t1.Split(' ').Length - t2.Split(' ').Length, primerTexto, segundoTexto);
            // Punto 3
            Console.WriteLine($"{NewLine}3era Comparación - Texto con más vocales:");
            Comparar((t1, t2) => ContarVocales(t1) - ContarVocales(t2), primerTexto, segundoTexto);
            // Punto 4
            Console.WriteLine($"{NewLine}4ta Comparación - Texto con más signos de puntuación:");
            Comparar((t1, t2) => ContarSignosPuntuacion(t1) - ContarSignosPuntuacion(t2), primerTexto, segundoTexto);
            // Punto 5
        }

        public static int ContarVocales(string texto)
        {
            List<char> vocales = new List<char>()
            {
                'a', 'á', 'A', 'Á', 'e', 'é', 'E', 'É',
                'i', 'í', 'I', 'Í', 'o', 'ó', 'O', 'Ó',
                'u', 'ú', 'U', 'Ú'
            };

            return ContarCaracteres(texto, vocales);
        }

        public static int ContarSignosPuntuacion(string texto)
        {
            List<char> signosPuntuacion = new List<char>()
            {
                '.', ';', ','
            };

            return ContarCaracteres(texto, signosPuntuacion);
        }

        public static int ContarCaracteres(string texto, List<char> caracteres)
        {
            int cantidadCaracteres = 0;

            foreach (char caracter in texto)
            {
                if (caracteres.Contains(caracter))
                {
                    cantidadCaracteres++;
                }
            }

            return cantidadCaracteres;
        }

        public static void Comparar(DelegadoComparacion delegadoComparacion, string texto1, string texto2)
        {
            string t;
            if(delegadoComparacion(texto1, texto2) != 0)
            {
                if(delegadoComparacion(texto1, texto2) > 0)
                {
                    t = $"{texto1} Es mayor";
                }
                else
                {
                    t = $"{texto2} Es mayor";
                }
            }
            else
            {
                t = "Ambos textos son iguales";
            }
            Console.WriteLine(t);
        }
    }
}
