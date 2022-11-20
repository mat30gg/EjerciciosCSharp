using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BInterfaces1
{
    public class Comercial : Avion
    {
        private protected int _capacidadPasajeros;
        public Comercial(double precio, double velocidad, int capacidad) : base(precio, velocidad)
        {
            this._capacidadPasajeros = capacidad;
        }
    }
}
