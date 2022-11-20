using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmCartelera : Form
    {
        private static string rutaConfiguracion;
        static FrmCartelera()
        {
            rutaConfiguracion = Path.Combine(Environment.SpecialFolder.ApplicationData.ToString(), "configuracion.json");
        }
        public FrmCartelera()
        {
            InitializeComponent();
        }

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {
            lblTitulo.Text = txtTitulo.Text;
        }

        private void rtxtMensaje_TextChanged(object sender, EventArgs e)
        {
            lblMensaje.Text = rtxtMensaje.Text;
        }
        
        private Color ElegirColor(Color colorActual)
        {
            colorDialog.Color = colorActual;
            colorDialog.ShowDialog();
            return colorDialog.Color;
        }
        private void btnColorPanel_Click(object sender, EventArgs e)
        {
            pnlCartel.BackColor = ElegirColor(pnlCartel.BackColor);
        }

        private void btnColorTitulo_Click(object sender, EventArgs e)
        {
            lblTitulo.ForeColor = ElegirColor(lblTitulo.ForeColor);
        }

        private void btnColorMensaje_Click(object sender, EventArgs e)
        {
            lblMensaje.ForeColor = ElegirColor(lblMensaje.ForeColor);
        }

        private void FrmCartelera_Load(object sender, EventArgs e)
        {
            this.LeerConfiguracionJson(rutaConfiguracion);
        }

        private void ConfigSet(Cartel cartel)
        {
            try
            {
                pnlCartel.BackColor = Color.FromArgb(cartel.ColorARGB);

                txtTitulo.Text = cartel.Titulo.Contenido;
                lblTitulo.ForeColor = Color.FromArgb(cartel.Titulo.ColorARGB);

                rtxtMensaje.Text = cartel.Mensaje.Contenido;
                lblMensaje.ForeColor = Color.FromArgb(cartel.Mensaje.ColorARGB);
            }
            catch(Exception ex)
            {
                MensajeError(ex);
            }
        }

        private void MensajeError(Exception ex)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(ex.Message);
            MessageBox.Show(sb.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnGuardarConfiguracion_Click(object sender, EventArgs e)
        {
            Cartel cart = LeerConfiguracionActual();
            string cartelJson = JsonSerializer.Serialize(cart, typeof(Cartel));
            ActualizarConfiguracionJson(cartelJson);
        }

        private Cartel LeerConfiguracionActual()
        {
            Texto titulo = new Texto(lblTitulo.Text, lblTitulo.ForeColor.ToArgb());
            Texto mensaje = new Texto(lblMensaje.Text, lblMensaje.ForeColor.ToArgb());
            Cartel cartel = new Cartel(pnlCartel.BackColor.ToArgb(), titulo, mensaje);
            return cartel;
        }

        private void LeerConfiguracionJson(string ruta)
        {
            if (File.Exists(ruta))
            {
                try
                {
                    string jsonString = File.ReadAllText(ruta);
                    Cartel cartel = JsonSerializer.Deserialize<Cartel>(jsonString);
                    ConfigSet(cartel);
                }
                catch (JsonException)
                {
                    MessageBox.Show("El archivo de configuracion no se encuentra en el formato correcto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MensajeError(ex);
                }
            }
        }

        private void ActualizarConfiguracionJson(string cartelJson)
        {
            if (File.Exists(rutaConfiguracion))
            {
                using (StreamWriter swrite = new StreamWriter(rutaConfiguracion))
                {
                    try
                    {
                        swrite.Write(cartelJson);
                    }
                    catch (Exception ex)
                    {
                        MensajeError(ex);
                    }
                    finally
                    {
                        swrite.Dispose();
                        swrite.Close();
                    }
                }
            }
        }

        private void EliminarConfiguracionJson()
        {
            try
            {
                if (File.Exists(rutaConfiguracion))
                {
                    File.Delete(rutaConfiguracion);
                }
                this.ConfigDefault();
            }
            catch (Exception ex)
            {
                MensajeError(ex);
            }
        }

        private void btnImportarConfiguracion_Click(object sender, EventArgs e)
        {

            OpenFileDialog openConfig = new OpenFileDialog();
            openConfig.Filter = "Json files(*.json)|*.json";
            openConfig.ShowDialog();
            this.LeerConfiguracionJson(openConfig.FileName);
        }

        private void btnEliminarConfiguracion_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro de que desea eliminar la configuracion?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if(result == DialogResult.OK)
            {
                this.EliminarConfiguracionJson();
            }
        }
        private void ConfigDefault()
        {
            txtTitulo.Text = "Título";
            lblTitulo.ForeColor = Control.DefaultForeColor;

            rtxtMensaje.Text = "Mensaje";
            lblMensaje.ForeColor = Control.DefaultForeColor;

            pnlCartel.BackColor = Control.DefaultBackColor;
        }
    }
}
