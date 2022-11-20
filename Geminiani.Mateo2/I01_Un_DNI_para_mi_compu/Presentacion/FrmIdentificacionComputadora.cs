using System.Windows.Forms;
using System.IO;
using System;

namespace Presentacion
{
    public partial class FrmIdentificacionComputadora : Form
    {
        public FrmIdentificacionComputadora()
        {
            InitializeComponent();
        }

        private void FrmIdentificacionComputadora_Load(object sender, System.EventArgs e)
        {
            this.Text = "Compu de " + Environment.UserName;
            this.ConfigurarLogoSistemaOperativo();
            this.lblSistemaOperativo.Text = "Sistema operativo: " + Environment.OSVersion;
            this.lblNombreMaquina.Text = "Nombre de la maquina: " + Environment.MachineName;
            this.ConfigurarArquitectura();
            this.lblCantProcesadores.Text = "Cant. procesadores: " + Environment.ProcessorCount + " procesadores logicos";
            this.lblDirectorioActual.Text = "Identificacion ejecutada en: " + Environment.NewLine + Environment.CurrentDirectory;
            this.ConfigurarEspacioTotalYDisponible();
        }

        private void ConfigurarLogoSistemaOperativo()
        {
            if(OperatingSystem.IsMacOS())
            {
                this.picboxSistemaOperativo.Image = Properties.Resources.mac;
            }
            if(OperatingSystem.IsLinux())
            {
                this.picboxSistemaOperativo.Image = Properties.Resources.linux;
            }
            if(OperatingSystem.IsWindows())
            {
                this.picboxSistemaOperativo.Image = Properties.Resources.windows;
            }
        }

        private void ConfigurarArquitectura()
        {
            this.lblArquitectura.Text = Environment.Is64BitOperatingSystem ? "Arquitectura: 64 bits" : "Arquitectura 32 bits";
        }

        private void ConfigurarEspacioTotalYDisponible()
        {
            long espacioDispo = 0;
            long espacioTotal = 0;
            DriveInfo[] infoDrives = DriveInfo.GetDrives();
            foreach(DriveInfo inf in infoDrives)
            {
                if(inf.IsReady)
                {
                    espacioTotal += inf.TotalSize;
                    espacioDispo += inf.AvailableFreeSpace;
                }
            }
            espacioTotal = espacioTotal / 1073741824;
            espacioDispo = espacioDispo / 1073741824;
            lblEspacioTotal.Text = "Espacio total: " + espacioTotal + " Gigabytes";
            lblEspacioDisponible.Text = "Espacio disponible: " + espacioDispo + " Gigabytes";
        }
    }
}
