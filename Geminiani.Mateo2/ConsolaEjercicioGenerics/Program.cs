using System;
using Ejer_Genericos01_Torneo;

namespace ConsolaEjercicioGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Torneo<EquipoFutbol> torneoFulbo = new Torneo<EquipoFutbol>("Copa libertadores");
            Torneo<EquipoBasquet> torneoBasquet = new Torneo<EquipoBasquet>("NBA");
            EquipoFutbol EquipoBoca = new EquipoFutbol("Boca Juniors", new DateTime(1905, 4, 3));
            EquipoFutbol EquipoRiber = new EquipoFutbol("River Plate", new DateTime(1901, 5, 25));
            EquipoFutbol equipoELP = new EquipoFutbol("Estudiantes de La Plata", new DateTime(1905, 8, 4));
            EquipoBasquet equipoQuimsa = new EquipoBasquet("Quimsa", new DateTime(1989, 8, 13));
            EquipoBasquet equipoCC = new EquipoBasquet("Instituto Atletico Central Cordoba", new DateTime(1918, 8, 8));
            EquipoBasquet equipoBasquet3 = new EquipoBasquet("Club atletico obras sanitarias de la nacion", new DateTime(1917, 3, 27));
            torneoFulbo += EquipoBoca;
            torneoFulbo += EquipoRiber;
            torneoFulbo += equipoELP;
            torneoBasquet += equipoQuimsa;
            torneoBasquet += equipoCC;
            torneoBasquet += equipoBasquet3;
            Console.WriteLine(torneoFulbo.Mostrar());
            Console.WriteLine(torneoBasquet.Mostrar());
            Console.WriteLine(torneoFulbo.JugarPartido);
            Console.WriteLine(torneoFulbo.JugarPartido);
            Console.WriteLine(torneoFulbo.JugarPartido);
            Console.WriteLine(torneoBasquet.JugarPartido);
            Console.WriteLine(torneoBasquet.JugarPartido);
            Console.WriteLine(torneoBasquet.JugarPartido);
            Console.ReadKey();
        }
    }
}
