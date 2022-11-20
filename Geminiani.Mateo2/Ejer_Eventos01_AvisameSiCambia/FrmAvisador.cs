using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejer_Eventos01_AvisameSiCambia
{
    public partial class FrmAvisador : Form
    {
        private Persona persona;
        public FrmAvisador()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if(!(string.IsNullOrWhiteSpace(txbNombre.Text) && string.IsNullOrWhiteSpace(txbApellido.Text)))
            {
                if (persona is null)
                {
                    persona = new Persona(NotificarCambio);
                    btnCrear.Text = "Actualizar";
                }
                persona.Nombre = txbNombre.Text;
                persona.Apellido = txbApellido.Text;
                lblNombreCompleto.Text = persona.Mostrar();
            }
        }

        public void NotificarCambio(string cambio)
        {
            MessageBox.Show(cambio, "Se realizaron cambios");
        }
    }
}
