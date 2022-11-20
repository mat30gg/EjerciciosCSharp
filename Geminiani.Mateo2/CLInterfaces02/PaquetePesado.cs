using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLInterfaces02
{
    public class PaquetePesado : Paquete, IAfip
    {
        public override bool TienePrioridad
        {
            get
            {
                return false;
            }
        }
        public PaquetePesado(string codigoSeguimiento, decimal costoEnvio, string destino, string origen, double pesoKg)
                      : base(codigoSeguimiento, costoEnvio, destino, origen, pesoKg)
        {

        }
        decimal IAfip.Impuestos
        {
            get
            {
                return costoEnvio * 0.25M;
            }
        }
        public override decimal AplicarImpuestos()
        {
            return this.costoEnvio + this.Impuestos + ((IAfip)this).Impuestos;
        }
    }
}
