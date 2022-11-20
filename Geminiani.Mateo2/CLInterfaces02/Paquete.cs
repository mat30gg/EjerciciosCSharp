using System;
using System.Text;

namespace CLInterfaces02
{
    public abstract class Paquete : IAduana
    {
        private string codigoSeguimiento;
        protected decimal costoEnvio;
        private string destino;
        private string origen;
        private double pesoKg;
        public Paquete(string codigoSeguimiento,
                       decimal costoEnvio,
                       string destino,
                       string origen,
                       double pesoKg)
        {
            this.codigoSeguimiento = codigoSeguimiento;
            this.costoEnvio = costoEnvio;
            this.destino = destino;
            this.origen = origen;
            this.pesoKg = pesoKg;
        }
        public decimal Impuestos
        {
            get
            {
                return costoEnvio * 0.35M;
            }
        }
        public abstract bool TienePrioridad
        {
            get;
        }
        public string ObtenerInformacionDePaquete()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Codigo de seguimiento: {this.codigoSeguimiento}");
            sb.AppendLine($"Costo de envio: {this.costoEnvio}");
            sb.AppendLine($"Destino: {this.destino}");
            sb.AppendLine($"Origen: {this.origen}");
            sb.AppendLine($"Peso: {this.pesoKg}KG");
            sb.AppendLine(this.TienePrioridad ? "Tiene prioridad" : "No tiene prioridad");
            return sb.ToString();
        }
        public virtual decimal AplicarImpuestos()
        {
            return this.costoEnvio + this.Impuestos;
        }
    }
}
