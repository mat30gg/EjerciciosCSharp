
namespace Ejer_Hilos01_ElRelojero
{
    partial class ElRelojero
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblHora = new System.Windows.Forms.Label();
            this.timerHora = new System.Windows.Forms.Timer(this.components);
            this.rtbTexto = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHora.Location = new System.Drawing.Point(13, 9);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(90, 37);
            this.lblHora.TabIndex = 1;
            this.lblHora.Text = "label1";
            // 
            // rtbTexto
            // 
            this.rtbTexto.Location = new System.Drawing.Point(13, 63);
            this.rtbTexto.Name = "rtbTexto";
            this.rtbTexto.Size = new System.Drawing.Size(348, 143);
            this.rtbTexto.TabIndex = 2;
            this.rtbTexto.Text = "";
            // 
            // ElRelojero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 218);
            this.Controls.Add(this.rtbTexto);
            this.Controls.Add(this.lblHora);
            this.Name = "ElRelojero";
            this.Text = "ElRelojero";
            this.Load += new System.EventHandler(this.ElRelojero_Load);
            this.Shown += new System.EventHandler(this.ElRelojero_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer timerHora;
        private System.Windows.Forms.RichTextBox rtbTexto;
    }
}