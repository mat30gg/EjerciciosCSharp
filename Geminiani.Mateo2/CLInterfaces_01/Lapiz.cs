using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLInterfaces_01
{
    public class Lapiz : IAcciones
    {
        private float tamanioMina;
        public Lapiz(int unidades)
        {
            this.tamanioMina = unidades;
        }
        ConsoleColor IAcciones.Color
        {
            get
            {
                return ConsoleColor.Gray;
            }
            set
            {
                throw new NotImplementedException();
            }
        }
        float IAcciones.UnidadesDeEscritura
        {
            get
            {
                return tamanioMina;
            }
            set
            {
                this.tamanioMina = value;
            }
        }
        EscrituraWrapper IAcciones.Escribir(string texto)
        {
            int caracteres = texto.Trim().Length;
            this.tamanioMina -= caracteres * (float)0.1;
            return new EscrituraWrapper(texto, ConsoleColor.Gray);
        }
        bool IAcciones.Recargar(int unidades)
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"Lapiz, Color {((IAcciones)this).Color}, Nivel de mina {this.tamanioMina}");
            return sb.ToString();
        }
    }
}
