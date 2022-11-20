using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool aux = false;
            int val;
            string linea;
            do
            {
                if(aux)
                {
                    Console.WriteLine("ERROR. ¡Reingresar numero!");
                }
                linea = Console.ReadLine();
                aux = true;
            } while (int.TryParse(linea, out val) == false);
            Console.WriteLine($"El cuadrado del numero: {Math.Pow(val, 2)}");
            Console.WriteLine($"El cubo del numero: {Math.Pow(val, 3)}");
        }
    }
}
