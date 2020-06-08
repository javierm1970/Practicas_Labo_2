namespace Ejercicio_56_Archivos
{
    partial class Fmr_Ejercicio_56
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
            this.menuStripArchivos = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripArchivos = new System.Windows.Forms.StatusStrip();
            this.richTextBoxArchivo = new System.Windows.Forms.RichTextBox();
            this.toolStripStatusLabelArchivo = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStripArchivos.SuspendLayout();
            this.statusStripArchivos.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripArchivos
            // 
            this.menuStripArchivos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStripArchivos.Location = new System.Drawing.Point(0, 0);
            this.menuStripArchivos.Name = "menuStripArchivos";
            this.menuStripArchivos.Size = new System.Drawing.Size(800, 24);
            this.menuStripArchivos.TabIndex = 0;
            this.menuStripArchivos.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.guardarComoToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // guardarComoToolStripMenuItem
            // 
            this.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            this.guardarComoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.guardarComoToolStripMenuItem.Text = "Guardar Como";
            this.guardarComoToolStripMenuItem.Click += new System.EventHandler(this.guardarComoToolStripMenuItem_Click);
            // 
            // statusStripArchivos
            // 
            this.statusStripArchivos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelArchivo});
            this.statusStripArchivos.Location = new System.Drawing.Point(0, 428);
            this.statusStripArchivos.Name = "statusStripArchivos";
            this.statusStripArchivos.ShowItemToolTips = true;
            this.statusStripArchivos.Size = new System.Drawing.Size(800, 22);
            this.statusStripArchivos.TabIndex = 1;
            this.statusStripArchivos.Text = "hola";
            //this.statusStripArchivos.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStripArchivos_ItemClicked);
            // 
            // richTextBoxArchivo
            // 
            this.richTextBoxArchivo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxArchivo.Location = new System.Drawing.Point(0, 24);
            this.richTextBoxArchivo.Name = "richTextBoxArchivo";
            this.richTextBoxArchivo.Size = new System.Drawing.Size(800, 404);
            this.richTextBoxArchivo.TabIndex = 2;
            this.richTextBoxArchivo.Text = "";
            this.richTextBoxArchivo.TextChanged += new System.EventHandler(this.richTextBoxArchivo_TextChanged);
            // 
            // toolStripStatusLabelArchivo
            // 
            this.toolStripStatusLabelArchivo.Name = "toolStripStatusLabelArchivo";
            this.toolStripStatusLabelArchivo.Size = new System.Drawing.Size(0, 17);
            //this.toolStripStatusLabelArchivo.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // Fmr_Ejercicio_56
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBoxArchivo);
            this.Controls.Add(this.statusStripArchivos);
            this.Controls.Add(this.menuStripArchivos);
            this.MainMenuStrip = this.menuStripArchivos;
            this.Name = "Fmr_Ejercicio_56";
            this.Text = "Ejercicio_56";
            this.menuStripArchivos.ResumeLayout(false);
            this.menuStripArchivos.PerformLayout();
            this.statusStripArchivos.ResumeLayout(false);
            this.statusStripArchivos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripArchivos;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarComoToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStripArchivos;
        private System.Windows.Forms.RichTextBox richTextBoxArchivo;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelArchivo;
    }
}

