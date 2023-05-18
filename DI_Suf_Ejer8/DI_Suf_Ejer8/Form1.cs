using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DI_Suf_Ejer8
{
    public partial class Form1 : Form
    {
        static bool gradiente = false;
        static bool forma = false;
        static bool cambio = false;
        static bool click = false;
        public Form1()
        {
            InitializeComponent();
        }
            

        private void button1_Click(object sender, EventArgs e)
        {
            if (gradiente)
            {
                componente1.Gradiente = ComponenteEjer8.Componente.eGradiente.No;
                gradiente = false;
                componente1.Refresh();
            }
            else
            {
                componente1.Gradiente = ComponenteEjer8.Componente.eGradiente.Si;
                gradiente = true;
                componente1.Refresh();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (forma)
            {
                componente1.Marca = ComponenteEjer8.Componente.eMarca.Cruz;
                forma = false;
                componente1.Refresh();
            }
            else
            {
                componente1.Marca = ComponenteEjer8.Componente.eMarca.Circulo;
                forma = true;
                componente1.Refresh();
            }
        }

        private void componente1_ClickEnMarca(object sender, EventArgs e)
        {
            if (click)
            {
                this.Text = "click1";
                click = false;
            }
            else
            {
                this.Text = "click2";
                click = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (cambio)
            {
                componente1.Marca = ComponenteEjer8.Componente.eMarca.Nada;
                cambio = false;
                componente1.Refresh();
            }
            else
            {
                componente1.Marca = ComponenteEjer8.Componente.eMarca.Imagen;
                cambio = true;
                componente1.Refresh();
            }
        }

        private void componente1_ClickEnMarca_1(object sender, EventArgs e)
        {
            if (click)
            {
                this.Text = "click1";
                click = false;
            }
            else
            {
                this.Text = "click2";
                click = true;
            }
        }
    }
}
