using System;
using System.IO;
using System.Text;
using static System.Environment;

namespace Archivos01
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path = Environment.GetFolderPath(SpecialFolder.Desktop) + "\\Programacion\\UTN\\2° Cuatrimestre\\Laboratorio\\Ejercicios\\Geminiani.Mateo2\\MiArchivo.txt";
                string pathCompleto = @"C:\Users\mateo\Desktop\Programacion\UTN\2° Cuatrimestre\Laboratorio\Ejercicios\Geminiani.Mateo2\Archivos01";

                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Hola esta es una prueba de archivos");
                sb.AppendLine("Jaja");
                sb.AppendLine("Domingo dia del padre");

                //Guardar(path, sb.ToString(), false);

                Console.WriteLine(Leer(path));
                Console.ReadKey();

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void Guardar(string path, string texto)
        {
            StreamWriter stream = null;
            try
            {
                stream = new StreamWriter(path);

                stream.WriteLine(texto);

                stream.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if(stream is not null)
                {
                    stream.Close();
                }
            }
        }

        public static void Guardar(string path, string texto, bool agregar)
        {
            try
            {
                using(StreamWriter stream = new StreamWriter(path, agregar))
                {
                    stream.WriteLine(texto);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static string Leer(string path)
        {
            try
            {
                using(StreamReader stream = new StreamReader(path))
                {
                    return stream.ReadToEnd();
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
