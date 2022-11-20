using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BInterfaces1
{
    public class Privado : Avion
    {
        private protected int _valoracionDeServicioDeAbordo;
        public Privado(double precio, double velocidad, int valor) : base(precio, velocidad)
        {
            this._valoracionDeServicioDeAbordo = valor;
        }
    }
}
