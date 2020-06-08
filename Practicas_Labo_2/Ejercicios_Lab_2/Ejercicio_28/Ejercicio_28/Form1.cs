using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_28
{

    public partial class FrmDiccionario : Form
    {
        Dictionary<string,int> miDiccionario;
        public FrmDiccionario()
        {
            InitializeComponent();
            //miDiccionario = new SortedDictionary<string, int>();
        }
        private void FrmDiccionario_Load(object sender, EventArgs e)
        {
            miDiccionario = new Dictionary<string, int>();
        }
        private static int OrdenarDescendente(string s1, string s2)
        {
            return -s1.CompareTo(s2);
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string palabraClave;
            int indice;
            int desde = 0;
            int hasta = 0;
            bool flagEncontrado = false;

            for (int i = 0; i < richTextBox1.Text.Length; i++)
            {
                hasta++;

                if (richTextBox1.Text[i]==' ' || richTextBox1.Text.Length==i+1)
                {
                    if (richTextBox1.Text[i]==' ')
                    {
                        hasta--;
                    }
                    palabraClave = richTextBox1.Text.Substring(desde, (hasta));
                    desde = desde + hasta + 1;
                    hasta = 0;
                    foreach (KeyValuePair<string, int> item in this.miDiccionario)
                    {
                        if (item.Key == palabraClave)
                        {
                            flagEncontrado = true;
                            this.miDiccionario[item.Key]=item.Value + 1;
                            break;
                        }
                        flagEncontrado = false;
                    }
                    if (!(flagEncontrado))
                    {
                        indice = this.miDiccionario.Count;
                        this.miDiccionario.Add(palabraClave, 1);
                    }                    
                }
            }

            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("El diccionario cuenta con {0} Palabras",
                this.miDiccionario.Count);
            
            if (!(this.miDiccionario.Count <= 0))
            {
                foreach (KeyValuePair<string, int> item in miDiccionario)
                {
                    sb.AppendFormat("\n{0} {1}", item.Key, item.Value);
                }
                MessageBox.Show(sb.ToString());
            }
            else
            {
                sb.Append("\nDiccionario Vacio");
                MessageBox.Show(sb.ToString());
            }
            desde = 0;
            hasta = 0;
        }
    }
}
