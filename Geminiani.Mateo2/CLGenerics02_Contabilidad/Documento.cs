using System;

namespace CLGenerics02_Contabilidad
{
    public abstract class Documento
    {
        public int numero;
        public Documento(int numero)
        {
            this.numero = numero;
        }
    }
}
