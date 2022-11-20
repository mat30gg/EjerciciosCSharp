using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BInterfaces1
{
    public class Deportivo : Auto, IAFIP
    {
        private protected int _caballosFuerza;
        public Deportivo(double precio, string patente, int hp) : base(precio, patente)
        {
            this._caballosFuerza = hp;
        }
        double IAFIP.CalcularImpuesto()
        {
            return this._precio * 0.28;
        }
    }
}
