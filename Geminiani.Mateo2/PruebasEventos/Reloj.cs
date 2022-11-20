using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PruebasEventos
{
    public class Reloj
    {
        //Crea delegado
        public delegate void NotificadorCambioTiempo(object reloj, InfoTiempoEventArgs infoTiempo);

        //Declara un delegado del tipo NotificadorCambioTiempo para la instancia de reloj
        public event NotificadorCambioTiempo SegundoCambiado;

        public int hora;
        public int minuto;
        public int segundo;

        public void Ejecutar()
        {
            for (; ; )
            {
                // duerme la ejecucion 100 milisengundos
                Thread.Sleep(100);

                // obtiene hora actual
                DateTime dt = DateTime.Now;
                // si los segundos cambian
                // notifica a los suscriptores
                if (dt.Second != segundo)
                {
                    // crea una instancia de InfoTiempoEventArgs
                    // para pasar al suscriptor
                    InfoTiempoEventArgs infoTiempo = new InfoTiempoEventArgs(dt.Hour, dt.Minute, dt.Second);

                    // verifico que haya suscriptores al evento
                    if (SegundoCambiado is not null)
                    {
                        SegundoCambiado.Invoke(this, infoTiempo);
                    }
                }

                // actualizo el estado del objeto Reloj
                this.segundo = dt.Second;
                this.minuto = dt.Minute;
                this.hora = dt.Hour;
            }
        }
    }

    public class InfoTiempoEventArgs : EventArgs
    {
        public int hora;
        public int minuto;
        public int segundo;
        public InfoTiempoEventArgs(int h, int m, int s)
        {
            this.hora = h;
            this.minuto = m;
            this.segundo = s;
        }
    }
}
