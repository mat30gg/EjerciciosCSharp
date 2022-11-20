using System;
using System.Threading;
using System.Threading.Tasks;

namespace PruebasHilos
{
    class Program
    {
        static void Main(string[] args)
        {
            Task tarea = new Task(Accion);

            tarea.Start();
            Console.WriteLine("Tarea comenzo a ejecutarse Hilo principal: " + Thread.CurrentThread.ManagedThreadId);

            tarea.Wait();
            Console.WriteLine("Tarea finalizada Hilo principal: " + Thread.CurrentThread.ManagedThreadId);
        }
        static void Accion()
        {
            Console.WriteLine($"Task id: {Task.CurrentId}, Hilo secundario: {Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(4000);
        }
    }
}
