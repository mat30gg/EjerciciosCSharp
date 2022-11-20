using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PruebasEventos;

namespace PruebaEventos01
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            Reloj reloj = new Reloj();

            //Agrega la funcion "MostrarCambioTiempo" al delegado SegundoCambiado
            reloj.SegundoCambiado += MostrarCambioTiempo;

            reloj.Ejecutar();
        }

        public void MostrarCambioTiempo(object reloj, InfoTiempoEventArgs info)
        {
            lblTiempo.Text = $"{info.hora}:{info.minuto}:{info.segundo}";
        }
    }
}
