using System;

namespace PruebaMetExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabra = "Habia una vez truz";
            Console.WriteLine(palabra.ContarPalabras());
            Console.WriteLine(palabra.ContarPalabras(5));
            Console.ReadKey();
        }
    }

    public static class MiExtension
    {
        public static int ContarPalabras(this string str)
        {
            return str.Split(new char[] { ',', '.', '?', ' '}, StringSplitOptions.RemoveEmptyEntries).Length;
        }
        public static int ContarPalabras(this string str, int multiplicador)
        {
            return str.ContarPalabras() * multiplicador;
        }
    }
}
