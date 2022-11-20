using System;
using System.Collections.Generic;
using System.Text;

namespace Ejer_Genericos01_Torneo
{
    public class Torneo<T> where T : Equipo
    {
        private List<T> equipos;
        private string nombre;
        private Torneo()
        {
            equipos = new List<T>();
        }
        public Torneo(string nombre):this()
        {
            this.nombre = nombre;
        }
        public static bool operator ==(Torneo<T> t, T e)
        {
            bool retorn = false;
            foreach(T equipo in t.equipos)
            {
                if(equipo == e)
                {
                    retorn = true;
                    break;
                }
            }
            return retorn;
        }
        public static bool operator !=(Torneo<T> t, T e)
        {
            return !(t == e);
        }
        public static Torneo<T> operator+(Torneo<T> t, T e)
        {
            if((t is not null && e is not null) && t != e)
            {
                t.equipos.Add(e);
            }
            return t;
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder("Nombre del torneo: " + this.nombre);
            foreach(T equipo in this.equipos)
            {
                sb.AppendFormat($"\r\n{equipo.Ficha()}");
            }
            return sb.ToString();
        }
        private string CalcularPartido(T equipo1, T equipo2)
        {
            Random calcResultado = new Random();
            StringBuilder retResultados = new StringBuilder();
            retResultados.AppendFormat($"{equipo1.nombre} {calcResultado.Next(0, 10)} - {equipo2.nombre} {calcResultado.Next(0, 10)}");
            return retResultados.ToString();
        }
        public string JugarPartido
        {
            get
            {
                string resultado = "";
                if(this.equipos.Count > 0)
                {
                    T equipo1;
                    T equipo2;
                    Random random = new Random();
                    do {
                        equipo1 = this.equipos[random.Next(0, equipos.Count)];
                        equipo2 = this.equipos[random.Next(0, equipos.Count)];
                    } while (equipo1 == equipo2);
                    resultado = CalcularPartido(equipo1, equipo2);
                }
                return resultado;
            }
        }
    }
}
