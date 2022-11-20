using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BInterfaces1
{
    public class Familiar : Auto
    {
        private protected int _cantidadAsientos;
        public Familiar(double precio, string patente, int cAsiento) : base(precio, patente)
        {
            this._cantidadAsientos = cAsiento;
        }
    }
}
