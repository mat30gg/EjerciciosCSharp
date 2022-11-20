using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace Ejer_Serializacion01_LaListaDelSuper
{
    public partial class FrmListaSuper : Form
    {
        private List<String> listaSupermercado;
        private static string rutaArchivo;
        static FrmListaSuper()
        {
            string rutaAplicacion = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            const string nombreArchivo = "listaSupermercado.xml";
            rutaArchivo = Path.Combine(rutaAplicacion, nombreArchivo);
        }
        public FrmListaSuper()
        {
            listaSupermercado = new List<String>();
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rutaArchivo);
            FrmAltaModificacion frmAlta = new FrmAltaModificacion("Agregar objeto", "", "Agregar");
            frmAlta.ShowDialog();
            if(frmAlta.DialogResult == DialogResult.OK)
            {
                listaSupermercado.Add(frmAlta.Objeto);
                GuardarCambios();
                ActualizarLista();
            }
        }

        private void btnRem_Click(object sender, EventArgs e)
        {
            if(lstObjetos.SelectedIndex != -1)
            {
                listaSupermercado.RemoveAt(lstObjetos.SelectedIndex);
                GuardarCambios();
                ActualizarLista();
            }
            else
            {
                MessageBox.Show("Seleccione un elemento de la lista.", "Aviso");
            }
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            if(lstObjetos.SelectedIndex != -1)
            {
                FrmAltaModificacion frmMod = new FrmAltaModificacion("Modificar objeto", lstObjetos.SelectedItem.ToString(), "Modificar");
                frmMod.ShowDialog();
                if (frmMod.DialogResult == DialogResult.OK)
                {
                    lstObjetos.SelectedItem = frmMod.Objeto;
                    GuardarCambios();
                    ActualizarLista();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un elemento de la lista.", "Aviso");
            }
        }

        private void FrmListaSuper_Load(object sender, EventArgs e)
        {
            this.ConfigurarTooltips();
            this.DescargarDatosXml();
            this.ActualizarLista();
        }

        public void ActualizarLista()
        {
            lstObjetos.DataSource = null;
            lstObjetos.DataSource = listaSupermercado;
        }
        public void DescargarDatosXml()
        {
            if (File.Exists(rutaArchivo))
            {
                using (StreamReader lectorArchivo = new StreamReader(rutaArchivo))
                {
                    try
                    {
                        XmlSerializer xmlSerial = new XmlSerializer(listaSupermercado.GetType());
                        listaSupermercado = xmlSerial.Deserialize(lectorArchivo) as List<String>;
                    }
                    catch (Exception ex)
                    {
                        MostrarMensajeDeError(ex);
                    }
                }
            }
        }
        public void GuardarCambios()
        {
            using(StreamWriter sr = new StreamWriter(rutaArchivo))
            {
                try
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(listaSupermercado.GetType());
                    xmlSerializer.Serialize(sr, listaSupermercado);
                }
                catch(Exception ex)
                {
                    MostrarMensajeDeError(ex);
                }
            }
        }
        private void ConfigurarTooltips()
        {
            toolTipAgregar.SetToolTip(btnAdd, "Agregar objeto");
            toolTipRemover.SetToolTip(btnRem, "Eliminar objeto");
            toolTipModificar.SetToolTip(btnMod, "Modificar objeto");
        }
        private void MostrarMensajeDeError(Exception ex)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(ex.Message);
            sb.AppendLine();
            sb.AppendLine(ex.StackTrace);

            MessageBox.Show(sb.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
