using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int val;
            string linea;
            int cont = 0;
            do
            {
                Console.Write("Valor: ");
                linea = Console.ReadLine();
                if(int.TryParse(linea, out val))
                {
                    if(val > 0)
                    {
                        for(int x = 0; x <= val; x++)
                        {
                            for(int y = 1; y <= x; y++)
                            {
                                if(x % y == 0)
                                {
                                    cont++;
                                }
                            }
                            if(cont <= 2)
                            {
                                Console.WriteLine("*" + x);
                            }
                            cont = 0;
                        }
                    }
                }
            } while (linea != "salir");

        }
    }
}
