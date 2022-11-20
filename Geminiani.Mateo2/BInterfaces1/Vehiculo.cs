using System;

namespace BInterfaces1
{
    public abstract class Vehiculo
    {
        private protected double _precio;
        public virtual void MostrarPrecio()
        {
            Console.Write(this._precio);
        }
        public Vehiculo(double _precio)
        {
            this._precio = _precio;
        }
    }
}
