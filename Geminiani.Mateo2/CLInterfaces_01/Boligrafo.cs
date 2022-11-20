using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLInterfaces_01
{
    public class Boligrafo : IAcciones
    {
        private ConsoleColor colorTinta;
        private float tinta;
        public Boligrafo(int unidades, ConsoleColor color)
        {
            this.tinta = unidades;
            this.colorTinta = color;
        }
        public ConsoleColor Color
        {
            get
            {
                return this.colorTinta;
            }
            set
            {
                this.colorTinta = value;
            }
        }
        public float UnidadesDeEscritura
        {
            get
            {
                return this.tinta;
            }
            set
            {

            }
        }
        public EscrituraWrapper Escribir(string texto)
        {
            int caracteres = texto.Trim().Length;
            tinta -= caracteres * (float)0.3;
            return new EscrituraWrapper(texto, colorTinta);
        }
        public bool Recargar(int unidades)
        {
            this.tinta += unidades;
            return true;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"Boligrafo, Color {this.Color}, nivel de tinta {this.tinta}");
            return sb.ToString();
        }
    }
}
