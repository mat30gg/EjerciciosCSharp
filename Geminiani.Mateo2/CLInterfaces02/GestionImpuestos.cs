using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CLInterfaces02
{
    public class GestionImpuestos
    {
        private List<IAduana> impuestosAduana;
        private List<IAfip> impuestosAfip;
        public GestionImpuestos()
        {
            impuestosAduana = new List<IAduana>();
            impuestosAfip = new List<IAfip>();
        }
        public decimal CalcularTotalImpuestosAduana()
        {
            decimal retorn = 0;
            foreach(Paquete pac in impuestosAduana)
            {
                retorn += pac.Impuestos;
            }
            return retorn;
        }
        public decimal CalcularTotalImpuestosAfip()
        {
            decimal retorn = 0;
            foreach (Paquete pac in impuestosAfip)
            {
                retorn += ((IAfip)pac).Impuestos;
            }
            return retorn;
        }
        public void RegistrarImpuestos(IEnumerable<Paquete> paquetes)
        {
            foreach (Paquete pac in paquetes)
            {
                RegistrarImpuestos(pac);
            }
        }
        public void RegistrarImpuestos(Paquete paquete)
        {
            impuestosAduana.Add(paquete);
            if(paquete is IAfip)
            {
                IAfip paqueteAfip = (IAfip)paquete;
                impuestosAfip.Add(paqueteAfip);
            }
        }
    }
}
