namespace Ejercicio_60_Sql
{
    partial class FrmProductos
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
            this.groupBoxControles = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAlta = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.textBoxStock = new System.Windows.Forms.TextBox();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.LblNumber = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBoxControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxControles
            // 
            this.groupBoxControles.Controls.Add(this.btnBuscar);
            this.groupBoxControles.Controls.Add(this.btnAlta);
            this.groupBoxControles.Controls.Add(this.button1);
            this.groupBoxControles.Controls.Add(this.btnListar);
            this.groupBoxControles.Controls.Add(this.textBoxStock);
            this.groupBoxControles.Controls.Add(this.textBoxNumber);
            this.groupBoxControles.Controls.Add(this.textBoxName);
            this.groupBoxControles.Controls.Add(this.textBoxID);
            this.groupBoxControles.Controls.Add(this.lblStock);
            this.groupBoxControles.Controls.Add(this.LblNumber);
            this.groupBoxControles.Controls.Add(this.lblName);
            this.groupBoxControles.Controls.Add(this.lblID);
            this.groupBoxControles.Location = new System.Drawing.Point(12, 12);
            this.groupBoxControles.Name = "groupBoxControles";
            this.groupBoxControles.Size = new System.Drawing.Size(309, 426);
            this.groupBoxControles.TabIndex = 1;
            this.groupBoxControles.TabStop = false;
            this.groupBoxControles.Text = "Productos";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(91, 328);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(133, 41);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(6, 255);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(134, 45);
            this.btnAlta.TabIndex = 10;
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(169, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 45);
            this.button1.TabIndex = 9;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(91, 375);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(133, 45);
            this.btnListar.TabIndex = 8;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click_1);
            // 
            // textBoxStock
            // 
            this.textBoxStock.Location = new System.Drawing.Point(91, 217);
            this.textBoxStock.Name = "textBoxStock";
            this.textBoxStock.Size = new System.Drawing.Size(212, 20);
            this.textBoxStock.TabIndex = 7;
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(91, 159);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(212, 20);
            this.textBoxNumber.TabIndex = 6;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(91, 106);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(212, 20);
            this.textBoxName.TabIndex = 5;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(91, 57);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(85, 20);
            this.textBoxID.TabIndex = 4;
            // 
            // lblStock
            // 
            this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(6, 214);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(79, 23);
            this.lblStock.TabIndex = 3;
            this.lblStock.Text = "Stock";
            // 
            // LblNumber
            // 
            this.LblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumber.Location = new System.Drawing.Point(6, 156);
            this.LblNumber.Name = "LblNumber";
            this.LblNumber.Size = new System.Drawing.Size(79, 23);
            this.LblNumber.TabIndex = 2;
            this.LblNumber.Text = "Number";
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(6, 103);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(79, 23);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblID
            // 
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(6, 54);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(79, 23);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(327, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(535, 426);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBoxControles);
            this.Name = "FrmProductos";
            this.Text = "Alta y Modificacion de Productos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxControles.ResumeLayout(false);
            this.groupBoxControles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxControles;
        //private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.TextBox textBoxStock;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label LblNumber;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

