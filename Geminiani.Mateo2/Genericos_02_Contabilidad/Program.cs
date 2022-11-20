using System;
using CLGenerics02_Contabilidad;

namespace Genericos_02_Contabilidad
{
    class Program
    {
        static void Main(string[] args)
        {
            Factura compra1 = new Factura(1000000);
            Factura compra2 = new Factura(2000000);
            Factura compra3 = new Factura(3000000);
            Recibo re1 = new Recibo(12);
            Contabilidad<Factura, Recibo> cont1 = new Contabilidad<Factura, Recibo>();
            cont1 += compra1;
            cont1 += compra2;
            cont1 += compra3;
            cont1 += re1;
            foreach(Documento doc in cont1.ingresos)
            {
                Console.WriteLine(doc.numero);
            }
            foreach (Documento doc in cont1.egresos)
            {
                Console.WriteLine(doc.numero);
            }
            Console.ReadKey();
        }
    }
}
