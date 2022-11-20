using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLCronica
{
    public static class DateTimeExtension
    {
        public static string ObtenerPlacaCronicaTV(this DateTime dt, Estaciones estacion)
        {
            int diasHastaEstacion;
            DateTime fechaInicioEstacion = new DateTime();
            switch(estacion)
            {
                case Estaciones.Otonio:
                    fechaInicioEstacion = DateTime.Parse("21/3");
                    break;
                case Estaciones.Invierno:
                    fechaInicioEstacion = DateTime.Parse("21/6");
                    break;
                case Estaciones.Primavera:
                    fechaInicioEstacion = DateTime.Parse("21/9");
                    break;
                case Estaciones.Verano:
                    fechaInicioEstacion = DateTime.Parse("21/12");
                    break;
            }
            diasHastaEstacion = (fechaInicioEstacion - dt).Days;
            if(dt > fechaInicioEstacion)
            {
                diasHastaEstacion += 365;
            }
            return $"Faltan {diasHastaEstacion} dias para {estacion.ToString()}";
        }
    }
}
