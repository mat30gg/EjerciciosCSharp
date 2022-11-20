using System;
using CLCronica;

namespace CCronica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Today.ObtenerPlacaCronicaTV(Estaciones.Otonio));
            Console.WriteLine(DateTime.Today.ObtenerPlacaCronicaTV(Estaciones.Invierno));
            Console.WriteLine(DateTime.Today.ObtenerPlacaCronicaTV(Estaciones.Primavera));
            Console.WriteLine(DateTime.Today.ObtenerPlacaCronicaTV(Estaciones.Verano));
            Console.ReadKey();
        }
    }
}
