using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BInterfaces1
{
    public abstract class Auto : Vehiculo
    {
        private protected string _patente;
        public Auto(double precio, string patente) : base(precio)
        {
            this._patente = patente;
        }
        public virtual void MostrarPatente()
        {
            Console.Write(this._patente);
        }
    }
}
