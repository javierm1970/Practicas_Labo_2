﻿namespace Ejercicio_71_Form
{
    partial class FrmMostrar
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
            this.lblEtiqueta = new System.Windows.Forms.Label();
            this.pictureBoxMostrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEtiqueta
            // 
            this.lblEtiqueta.AutoSize = true;
            this.lblEtiqueta.Location = new System.Drawing.Point(26, 47);
            this.lblEtiqueta.Name = "lblEtiqueta";
            this.lblEtiqueta.Size = new System.Drawing.Size(46, 13);
            this.lblEtiqueta.TabIndex = 0;
            this.lblEtiqueta.Text = "Etiqueta";
            // 
            // pictureBoxMostrar
            // 
            this.pictureBoxMostrar.Location = new System.Drawing.Point(29, 88);
            this.pictureBoxMostrar.Name = "pictureBoxMostrar";
            this.pictureBoxMostrar.Size = new System.Drawing.Size(220, 164);
            this.pictureBoxMostrar.TabIndex = 1;
            this.pictureBoxMostrar.TabStop = false;
            // 
            // FrmMostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 291);
            this.Controls.Add(this.pictureBoxMostrar);
            this.Controls.Add(this.lblEtiqueta);
            this.Name = "FrmMostrar";
            this.Text = "FrmMostrar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMostrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEtiqueta;
        private System.Windows.Forms.PictureBox pictureBoxMostrar;
    }
}