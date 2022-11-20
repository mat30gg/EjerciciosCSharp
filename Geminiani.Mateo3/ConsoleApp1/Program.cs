using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 0, max = 0;
            int temp;
            float prom = 0;
            for(int x = 0; x < 5; x++)
            {
                temp = int.Parse(Console.ReadLine());
                if(x == 0)
                {
                    min = temp;
                    max = temp;
                    prom = temp;
                }
                else
                {
                    prom += temp;
                    if(temp < min)
                    {
                        min = temp;
                    }
                    if(temp > max)
                    {
                        max = temp;
                    }
                }
            }
            prom = prom / 5;
            Console.WriteLine($"Valor maximo: {max}");
            Console.WriteLine($"Valor minimo: {min}");
            Console.WriteLine($"Promedio: {prom}");
        }
    }
}
