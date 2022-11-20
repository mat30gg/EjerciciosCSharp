using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejer_Hilos01_ElRelojero
{
    public partial class ElRelojero : Form
    {
        public ElRelojero()
        {
            InitializeComponent();
        }

        private void ElRelojero_Load(object sender, EventArgs e)
        {
            //Task reloj = Task.Run(AsignarHora);
            timerHora.Tick += new EventHandler(AsignarHoraEvento);

            timerHora.Interval = 1000;
            timerHora.Start();

        }

        private void AsignarHora()
        {
            while (true)
            {
                //Punto 1
                if (lblHora.InvokeRequired == true)
                {
                    //this.lblHora.BeginInvoke((MethodInvoker)delegate
                    //{
                    //    this.lblHora.Text = DateTime.Now.ToString();
                    //});
                    Action action = new Action(() => { this.lblHora.Text = DateTime.Now.ToString(); });
                    this.lblHora.BeginInvoke(action);
                }
                /* V- Para usar multihilo*/
                else 
                {
                    this.lblHora.Text = DateTime.Now.ToString();
                }
                //Thread.Sleep(1000);
            }
        }

        private void AsignarHoraEvento(Object myObject, EventArgs myEventArgs)
        {
            Task reloj = Task.Run(AsignarHora);
        }

        //this.rtbEvolucion.BeginInvoke((MethodInvoker)delegate ()
        //        {
        //            this.rtbEvolucion.Text += sb.ToString();
        //        }
        //        );

        private void ElRelojero_Shown(object sender, EventArgs e)
        {

        }
    }
}
