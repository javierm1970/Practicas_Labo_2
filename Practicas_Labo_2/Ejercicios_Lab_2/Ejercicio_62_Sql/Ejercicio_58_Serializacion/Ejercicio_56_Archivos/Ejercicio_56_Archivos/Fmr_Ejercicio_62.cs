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
using Ejercicio_62;

namespace Ejercicio_56_Archivos
{
    [Serializable]
    public partial class Fmr_Ejercicio_62 : Form
    {
        string pathArchivo;
        public Fmr_Ejercicio_62()
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
            PuntoDat archivoDat = new PuntoDat();
            PuntoTxt archivoTxt = new PuntoTxt();

            OpenFileDialog abrir = new OpenFileDialog();
            abrir.InitialDirectory = pathArchivo;
            abrir.Filter = "txt files (*.txt)|*.txt|dat files (*.dat)|*.dat|All files (*.*)|*.*";

            if (abrir.ShowDialog() == DialogResult.OK)
            {
                this.pathArchivo = abrir.FileName;
                if (Path.GetExtension(this.pathArchivo) == ".txt")
                {
                    this.richTextBoxArchivo.Text = ((IArchivos<string>)archivoTxt).Leer(this.pathArchivo);
                }
                else if (Path.GetExtension(this.pathArchivo) == ".dat")
                {
                    archivoDat = ((IArchivos<PuntoDat>)archivoDat).Leer(this.pathArchivo);
                    this.richTextBoxArchivo.Text = archivoDat.Contenido;
                } 
            }



            //if (abrir.ShowDialog() == DialogResult.OK)
            //{
            //    this.pathArchivo = abrir.FileName;

            //    try
            //    {
            //        //this.richTextBoxArchivo.Text = lectura.ReadToEnd();
            //    }
            //    catch (Exception)
            //    {
            //        MessageBox.Show("No se pudo Abrir el archivo", "Error!", MessageBoxButtons.OK);
            //    }
            //    finally
            //    {
            //        //lectura.Close();
            //    }
            //}
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PuntoDat archivoDat = new PuntoDat();
            PuntoTxt archivoTxt = new PuntoTxt();
            
            if (Path.GetExtension(this.pathArchivo) == ".txt")
            {
                ((IArchivos<string>)archivoTxt).Guardar(this.pathArchivo, this.richTextBoxArchivo.Text);
            }

            else if (Path.GetExtension(this.pathArchivo) == ".dat")
            {
                archivoDat.Contenido = richTextBoxArchivo.Text;
                ((IArchivos<PuntoDat>)archivoDat).Guardar(this.pathArchivo, archivoDat);
            } 

            
            
            
            //StreamWriter miEscritura;
            //guardar.InitialDirectory = this.pathArchivo;

            //miEscritura = new StreamWriter(this.pathArchivo);

            //try
            //{
            //    miEscritura.Write(this.richTextBoxArchivo.Text.ToString());
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("No se pudo Guardar el archivo", "Error!", MessageBoxButtons.OK);
            //}
            //finally
            //{
            //    miEscritura.Close();
            //}
        }
        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PuntoDat archivoDat = new PuntoDat();
            PuntoTxt archivoTxt = new PuntoTxt();

            SaveFileDialog guardarComo = new SaveFileDialog();
            guardarComo.Filter = "txt files (*.txt)|*.txt|dat files (*.dat)|*.dat|All files (*.*)|*.*";
            
            guardarComo.InitialDirectory = this.pathArchivo;

            if (guardarComo.ShowDialog() == DialogResult.OK)
            {
                this.pathArchivo = guardarComo.FileName;
                if (Path.GetExtension(guardarComo.FileName) == ".txt")
                {
                    ((IArchivos<string>)archivoTxt).GuardarComo(this.pathArchivo, richTextBoxArchivo.Text);
                }
                else if (Path.GetExtension(guardarComo.FileName) == ".dat")
                {
                    archivoDat.Contenido = richTextBoxArchivo.Text;
                    ((IArchivos<PuntoDat>)archivoDat).GuardarComo(this.pathArchivo, archivoDat);
                }
                pathArchivo = guardarComo.FileName;
               this.guardarToolStripMenuItem_Click(sender, e);
            }
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("No se pudo Guardar el archivo", "Error!", MessageBoxButtons.OK);
            //}
        }
    }
}
