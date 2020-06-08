namespace Form_Centralita_Polimorfismo
{
    partial class FrmMenu
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
            this.btnGenLlamada = new System.Windows.Forms.Button();
            this.btnFacTotal = new System.Windows.Forms.Button();
            this.btnFacLocal = new System.Windows.Forms.Button();
            this.btnFacProvincial = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenLlamada
            // 
            this.btnGenLlamada.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenLlamada.Location = new System.Drawing.Point(0, 0);
            this.btnGenLlamada.Name = "btnGenLlamada";
            this.btnGenLlamada.Size = new System.Drawing.Size(257, 65);
            this.btnGenLlamada.TabIndex = 0;
            this.btnGenLlamada.Text = "Generar Llamada";
            this.btnGenLlamada.UseVisualStyleBackColor = true;
            this.btnGenLlamada.Click += new System.EventHandler(this.btnGenLlamada_Click);
            // 
            // btnFacTotal
            // 
            this.btnFacTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacTotal.Location = new System.Drawing.Point(0, 69);
            this.btnFacTotal.Name = "btnFacTotal";
            this.btnFacTotal.Size = new System.Drawing.Size(257, 65);
            this.btnFacTotal.TabIndex = 1;
            this.btnFacTotal.Text = "Facturación Total";
            this.btnFacTotal.UseVisualStyleBackColor = true;
            this.btnFacTotal.Click += new System.EventHandler(this.btnFacTotal_Click);
            // 
            // btnFacLocal
            // 
            this.btnFacLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacLocal.Location = new System.Drawing.Point(0, 137);
            this.btnFacLocal.Name = "btnFacLocal";
            this.btnFacLocal.Size = new System.Drawing.Size(257, 65);
            this.btnFacLocal.TabIndex = 2;
            this.btnFacLocal.Text = "Facturación Local";
            this.btnFacLocal.UseVisualStyleBackColor = true;
            this.btnFacLocal.Click += new System.EventHandler(this.btnFacLocal_Click);
            // 
            // btnFacProvincial
            // 
            this.btnFacProvincial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacProvincial.Location = new System.Drawing.Point(0, 206);
            this.btnFacProvincial.Name = "btnFacProvincial";
            this.btnFacProvincial.Size = new System.Drawing.Size(257, 65);
            this.btnFacProvincial.TabIndex = 3;
            this.btnFacProvincial.Text = "Facturación Provincial";
            this.btnFacProvincial.UseVisualStyleBackColor = true;
            this.btnFacProvincial.Click += new System.EventHandler(this.btnFacProvincial_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(0, 273);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(257, 65);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 341);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnFacProvincial);
            this.Controls.Add(this.btnFacLocal);
            this.Controls.Add(this.btnFacTotal);
            this.Controls.Add(this.btnGenLlamada);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Central Telefónica";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenLlamada;
        private System.Windows.Forms.Button btnFacTotal;
        private System.Windows.Forms.Button btnFacLocal;
        private System.Windows.Forms.Button btnFacProvincial;
        private System.Windows.Forms.Button btnSalir;
    }
}