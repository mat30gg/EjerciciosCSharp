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
    public partial class FrmTestDelegados : Form
    {
        public delegate void ActualizaNombreDelegate(string nombre);
        //Action<string> ActualizaNombreDelegate;
        private ActualizaNombreDelegate actualizaNombreDelegate;
        public FrmTestDelegados(ActualizaNombreDelegate actualizaNombreDelegate)
        {
            InitializeComponent();
            this.actualizaNombreDelegate = actualizaNombreDelegate;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if(actualizaNombreDelegate is not null)
            {
                actualizaNombreDelegate.Invoke(this.txtNombre.Text);
            }
        }
    }
}
