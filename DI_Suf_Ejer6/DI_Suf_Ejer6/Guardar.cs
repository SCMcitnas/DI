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

namespace DI_Suf_Ejer6
{
    public partial class Guardar : Form
    {
        String path = Environment.GetEnvironmentVariable("appdata") + "\\numeros.txt";
        public Guardar()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtbNombre.Text.Trim() == "")
            {
                lblFalloNombre.Text = "Introduzca un nombre";
            }else if(txtbNumero.Text.Trim() == "")
            {
                lblFalloNumero.Text = "Introduzca un numero";
            }
            else
            {
                using(StreamWriter sw = new StreamWriter(path, true))
                {
                    lblFalloNombre.Text = "";
                    lblFalloNumero.Text = "";
                    sw.Write(String.Format("{0};{1}", txtbNombre.Text, txtbNumero.Text));
                    sw.WriteLine();
                    txtbNombre.Text = "";
                    txtbNumero.Text = "";
                    this.Hide();
                }
            }
        }

        private void Guardar_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
