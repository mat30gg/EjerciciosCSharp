using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejer_Delegados01_ELDELEGADO
{
    public partial class FrmPrincipal : Form
    {
        FrmMostrar formMostrar;
        FrmTestDelegados formTest;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            formMostrar = new FrmMostrar();
            formMostrar.MdiParent = this;
            formTest = new FrmTestDelegados(formMostrar.ActualizarNombre);
            formTest.MdiParent = this;
        }

        private void testDelegadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formTest.Show();
            this.mostrarToolStripMenuItem.Enabled = true;
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formMostrar.Show();
        }
    }
}
