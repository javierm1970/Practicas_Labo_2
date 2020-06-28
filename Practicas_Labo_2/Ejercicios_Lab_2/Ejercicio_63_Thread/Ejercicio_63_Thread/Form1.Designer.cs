namespace Ejercicio_63_Thread
{
    partial class Form1
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lnlReloj = new System.Windows.Forms.Label();
            this.lblInt = new System.Windows.Forms.Label();
            this.lblString = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 64);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(327, 374);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // lnlReloj
            // 
            this.lnlReloj.AutoSize = true;
            this.lnlReloj.Location = new System.Drawing.Point(9, 33);
            this.lnlReloj.Name = "lnlReloj";
            this.lnlReloj.Size = new System.Drawing.Size(0, 13);
            this.lnlReloj.TabIndex = 1;
            // 
            // lblInt
            // 
            this.lblInt.AutoSize = true;
            this.lblInt.Location = new System.Drawing.Point(164, 33);
            this.lblInt.Name = "lblInt";
            this.lblInt.Size = new System.Drawing.Size(35, 13);
            this.lblInt.TabIndex = 2;
            this.lblInt.Text = "label1";
            // 
            // lblString
            // 
            this.lblString.AutoSize = true;
            this.lblString.Location = new System.Drawing.Point(270, 33);
            this.lblString.Name = "lblString";
            this.lblString.Size = new System.Drawing.Size(35, 13);
            this.lblString.TabIndex = 3;
            this.lblString.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 450);
            this.Controls.Add(this.lblString);
            this.Controls.Add(this.lblInt);
            this.Controls.Add(this.lnlReloj);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lnlReloj;
        private System.Windows.Forms.Label lblInt;
        private System.Windows.Forms.Label lblString;
    }
}

