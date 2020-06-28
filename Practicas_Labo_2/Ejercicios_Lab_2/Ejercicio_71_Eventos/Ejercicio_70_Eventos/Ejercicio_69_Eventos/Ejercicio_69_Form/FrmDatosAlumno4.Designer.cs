namespace Ejercicio_71_Form
{
    partial class FrmDatosAlumno4
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxFotoAlumno = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFotoAlumno)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxFotoAlumno
            // 
            this.pictureBoxFotoAlumno.Location = new System.Drawing.Point(114, 185);
            this.pictureBoxFotoAlumno.Name = "pictureBoxFotoAlumno";
            this.pictureBoxFotoAlumno.Size = new System.Drawing.Size(214, 170);
            this.pictureBoxFotoAlumno.TabIndex = 10;
            this.pictureBoxFotoAlumno.TabStop = false;
            // 
            // FrmDatosAlumno4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(367, 450);
            this.Controls.Add(this.pictureBoxFotoAlumno);
            this.Name = "FrmDatosAlumno4";
            this.Controls.SetChildIndex(this.lblNombre, 0);
            this.Controls.SetChildIndex(this.lblApellido, 0);
            this.Controls.SetChildIndex(this.lblDNI, 0);
            this.Controls.SetChildIndex(this.lblFoto, 0);
            this.Controls.SetChildIndex(this.textBoxNombre, 0);
            this.Controls.SetChildIndex(this.textBoxApellido, 0);
            this.Controls.SetChildIndex(this.textBoxDNI, 0);
            this.Controls.SetChildIndex(this.textBoxFoto, 0);
            this.Controls.SetChildIndex(this.btnAceptar, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.pictureBoxFotoAlumno, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFotoAlumno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxFotoAlumno;
    }
}
