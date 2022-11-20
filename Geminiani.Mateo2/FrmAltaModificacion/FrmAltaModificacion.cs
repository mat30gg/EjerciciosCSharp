using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejer_Serializacion01_LaListaDelSuper
{
    public partial class FrmAltaModificacion : Form
    {
        private FrmAltaModificacion()
        {
            InitializeComponent();
        }
        public FrmAltaModificacion(string titulo, string txbTexto, string btnAcTexto) : this()
        {
            this.Text = titulo;
            this.txtObjeto.Text = txbTexto;
            this.btnConfirmar.Text = btnAcTexto;
        }
        public string Objeto
        {
            get
            {
                return this.txtObjeto.Text;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(Objeto))
            {
                MessageBox.Show("Espacio vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
