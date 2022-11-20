using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer_Eventos01_AvisameSiCambia
{
    public class Persona
    {
        //Declaro el delegado para el evento
        public delegate void DelegadoString(string msg);
        //Declaro el evento para cuando cambia un dato
        public event DelegadoString EventoString;

        private string nombre = "";
        private string apellido = "";
        public Persona(DelegadoString delegadoCambio)
        {
            EventoString += delegadoCambio;
        }
        public string Nombre
        {
            set
            {
                if(this.nombre != value)
                {

                    //Le asigno al metodo vinculado con el delegado del evento
                    //el string "Se cambio nombre"
                    EventoString("Se cambio nombre");
                    this.nombre = value;

                }
            }
            get
            {
                return this.nombre;
            }
        }
        public string Apellido
        {
            set
            {
                if(this.apellido != value)
                {
                    //Le asigno al metodo vinculado con el delegado del evento
                    //el string "Se cambio apellido"
                    EventoString("Se cambio apellido");
                    this.apellido = value;

                }
            }
            get
            {
                return this.apellido;
            }
        }
        public string Mostrar()
        {
            return this.nombre + " " +this.apellido;
        }
    }
}
