using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DI_Suf_Ejer5
{
    public partial class Form1 : Form
    {
        bool controladorIcono = false;
        bool cambiarIcono = false;
        String titulo = "Titulo Formulario";
        String tituloEscrito = "";
        int controlTitulo;

        public Form1()
        {
            InitializeComponent();

            
            timer1.Interval = 200;
            timer1.Start();
            this.Text = "";
            controlTitulo = titulo.Length;
            lblElementos.Text = String.Format("Elementos: {0}",lb1.Items.Count.ToString());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (controladorIcono)
            {
                if (cambiarIcono)
                {
                    
                    Icon icon = new Icon("C:\\Users\\Santiago\\Source\\Repos\\DI_Suf_Ejer5\\1486564398-menu2_81519.ico");
                    this.Icon= icon;
                    cambiarIcono= false;
                }
                else
                {
                    Icon icon = new Icon("C:\\Users\\Santiago\\Source\\Repos\\DI_Suf_Ejer5\\contactlist_theuser_802.ico");
                    this.Icon = icon;
                    cambiarIcono = true;
                }
                controladorIcono=false;
            }
            else
            {
                controladorIcono = true;
            }

            if (controlTitulo > 0)
            {
                tituloEscrito = titulo.ElementAt(controlTitulo-1)+tituloEscrito;
                this.Text = String.Format("{0}", tituloEscrito);
                controlTitulo--;
            }
            else
            {
                controlTitulo = titulo.Length;
                tituloEscrito = "";
            }
            
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            lb1.Items.Add(txb.Text);
            lblElementos.Text = String.Format("Elementos: {0}", lb1.Items.Count.ToString());
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if(lb1.Items.Count != 0)
            {
                for(int i = lb1.SelectedItems.Count-1; i >=0; i--)
                {
                    lb1.Items.Remove(lb1.SelectedItems[i]);
                }
            }
            lblElementos.Text = String.Format("Elementos: {0}", lb1.Items.Count.ToString());
        }

        private void btnTraspasar(object sender, EventArgs e)
        {
            if (sender == btnTraspasar1 || sender==traspasarToolStripMenuItem)
            {
                for (int i = lb1.SelectedItems.Count - 1; i >= 0; i--)
                {
                    lb2.Items.Add(lb1.SelectedItems[i]);
                    lb1.Items.Remove(lb1.SelectedItems[i]);
                }
                lblElementos.Text = String.Format("Elementos: {0}", lb1.Items.Count.ToString());

            }
            else if(sender == btnTraspasar2 || sender == traspasarToolStripMenuItem1)
            {
                for (int i = lb2.SelectedItems.Count - 1; i >= 0; i--)
                {
                    lb1.Items.Add(lb2.SelectedItems[i]);
                    lb2.Items.Remove(lb2.SelectedItems[i]);
                }
                lblElementos.Text = String.Format("Elementos: {0}", lb1.Items.Count.ToString());
            }
        }

        private void lb1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (lb1.SelectedItems.Count != 0)
            {
                lblIndices.Text = "Indices: ";
                for (int i = lb1.SelectedItems.Count - 1; i >= 0; i--)
                {
                    lblIndices.Text += String.Format("\r\n{0}", lb1.SelectedItems[i].ToString());
                }
            }
            else
            {
                lblIndices.Text = "Indices:";
            }
        }
    }
}
