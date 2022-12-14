using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BInterfaces1
{
    public class Avion : Vehiculo, IAFIP
    {
        private protected double _velocidadMaxima;
        public Avion(double precio, double velMax) : base(precio)
        {
            this._velocidadMaxima = velMax;
        }
        public double CalcularImpuesto()
        {
            return this._precio * 0.33;
        }
    }
}
