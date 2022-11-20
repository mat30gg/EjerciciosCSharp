using System;

namespace Ejer_Delegados01
{
    class Program
    {
        private delegate int DelNumeros();

        static void Main(string[] args)
        {
            DelNumeros pin = Numero1;
            pin += Numero2;
            pin += Numero4;
            pin += Numero2;
            Action meto2 = Metodo2;
            meto2 += Metodo1;
            meto2 += Metodo2;
            meto2 += Metodo3;
            Action<string> meto4 = Metodo4;
            meto4 += Metodo4;
            meto2 += () => { Console.WriteLine("Fin del delegado meto2"); };
            meto4 += (msg) => { Console.WriteLine("Te deseo: " + msg); };

            meto4("Buenas tardes");
            meto2();
            pin();
            Console.ReadKey();
        }
        static void Metodo1()
        {
            Console.WriteLine("Este es el metodo 1");
        }
        static void Metodo2()
        {
            Console.WriteLine("Este es el metodo 2");
        }
        static void Metodo3()
        {
            Console.WriteLine("Este es el metodo 3");
        }
        static void Metodo4(string linea)
        {
            Console.WriteLine("Se escribio "+ linea);
        }
        static int Numero1()
        {
            Console.Write("1");
            return 1;
        }
        static int Numero2()
        {
            Console.Write("2");
            return 2;
        }
        static int Numero3()
        {
            Console.Write("3");
            return 3;
        }
        static int Numero4()
        {
            Console.Write("4");
            return 4;
        }
    }
}
