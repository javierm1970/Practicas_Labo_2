using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_56_Archivos
{
    public partial class Fmr_Ejercicio_56 : Form
    {
        string pathArchivo;
        public Fmr_Ejercicio_56()
        {
            InitializeComponent();
            this.pathArchivo = "D:\\prueba Archivos\\";
        }
        private void richTextBoxArchivo_TextChanged(object sender, EventArgs e)
        {
            this.toolStripStatusLabelArchivo.Text = this.richTextBoxArchivo.TextLength.ToString();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog abrir = new OpenFileDialog();
            abrir.InitialDirectory = pathArchivo;
            abrir.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            
            if (abrir.ShowDialog() == DialogResult.OK)
            {
                this.pathArchivo = abrir.FileName;
                StreamReader lectura = new StreamReader(pathArchivo);

                try
                {
                    this.richTextBoxArchivo.Text = lectura.ReadToEnd();
                }
                catch (Exception)
                {
                    MessageBox.Show("No se pudo Abrir el archivo", "Error!", MessageBoxButtons.OK);
                }
                finally
                {
                    lectura.Close();
                }
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter miEscritura;
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.InitialDirectory = pathArchivo;

            miEscritura = new StreamWriter(pathArchivo);

            try
            {
                miEscritura.Write(this.richTextBoxArchivo.Text.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo Guardar el archivo", "Error!", MessageBoxButtons.OK);
            }
            finally
            {
                miEscritura.Close();
            }
        }
        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardarComo = new SaveFileDialog();
            guardarComo.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            guardarComo.InitialDirectory = this.pathArchivo;

            try
            {
                if (guardarComo.ShowDialog() == DialogResult.OK)
                {
                    pathArchivo = guardarComo.FileName;
                    this.guardarToolStripMenuItem_Click(sender, e);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo Guardar el archivo", "Error!", MessageBoxButtons.OK);
            }
        }
    }
}
