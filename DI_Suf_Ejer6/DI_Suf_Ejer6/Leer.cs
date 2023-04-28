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
    public partial class Leer : Form
    {
        public Leer()
        {
            InitializeComponent();
        }

        private void Leer_Load(object sender, EventArgs e)
        {
            String path = Environment.GetEnvironmentVariable("appdata") + "\\numeros.txt";
            using (StreamReader sr = new StreamReader(path))
            {
                bool nombre = true;
                String fichero = sr.ReadToEnd();
                String[] lineas = fichero.Split(';');
                foreach(String linea in lineas)
                {
                    if (nombre)
                    {
                        txtNumeros.Text += String.Format("Nombre: {0,-20}", linea);
                        nombre = false;
                    }
                    else
                    {
                        txtNumeros.Text += String.Format("Tel: {0}\n", linea);
                        nombre = true;
                    }
                    
                    txtNumeros.Height= txtNumeros.Size.Height+20;
                }
            }
        }

        private void Leer_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel= true;
            this.Hide();
        }
    }
}
