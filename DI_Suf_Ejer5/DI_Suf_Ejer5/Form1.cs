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
    /*
     No rutas absolutas X
     label con índices
    taborder X
     */
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
                    String imagen = "\\source\\repos\\DI\\DI_Suf_Ejer5\\1486564398-menu2_81519.ico";
                    Icon icon = new Icon(Environment.GetEnvironmentVariable("homepath")+imagen);
                    this.Icon= icon;
                    cambiarIcono= false;
                }
                else
                {
                    String imagen = "\\source\\repos\\DI\\DI_Suf_Ejer5\\contactlist_theuser_802.ico";
                    Icon icon = new Icon(Environment.GetEnvironmentVariable("homepath")+imagen);
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
                tituloEscrito = titulo[controlTitulo-1]+tituloEscrito;
                this.Text = String.Format("{0}", tituloEscrito);
                controlTitulo--;
            }
            else
            {
                controlTitulo = titulo.Length;
                tituloEscrito = "";
            }
            
        }

        private void btnAñadir_Click(object sender, EventArgs e)  // Ojo, el this.Enter sobra
        {
            lb1.Items.Add(txb.Text);
            lblElementos.Text = String.Format("Elementos: {0}", lb1.Items.Count.ToString());
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
           // if(lb1.Items.Count != 0)
            {
                for(int i = lb1.SelectedItems.Count-1; i >=0; i--)
                {
                    lb1.Items.Remove(lb1.SelectedItems[i]);
                }
            }
            //while (lb1.SelectedIndices.Count > 0)
            //{
            //    lb1.Items.RemoveAt(lb1.SelectedIndex);
            //}


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
                toolTip1.SetToolTip(this.lb2, String.Format("Tabla 2\r\nElementos: {0}", lb2.Items.Count.ToString()));
            }
            else if(sender == btnTraspasar2 || sender == traspasarToolStripMenuItem1)
            {
                for (int i = lb2.SelectedItems.Count - 1; i >= 0; i--)
                {
                    lb1.Items.Add(lb2.SelectedItems[i]);
                    lb2.Items.Remove(lb2.SelectedItems[i]);
                }
                lblElementos.Text = String.Format("Elementos: {0}", lb1.Items.Count.ToString());

                toolTip1.SetToolTip(this.lb2, String.Format("Tabla 2\r\nElementos: {0}", lb2.Items.Count.ToString()));
            }
        }

        private void lb1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (lb1.SelectedItems.Count != 0)
            {
                lblIndices.Text = "Indices: ";
                //for (int i = lb1.SelectedItems.Count - 1; i >= 0; i--)
                //{
                //    for (int j = 0; j < lb1.Items.Count; j++)
                //    {
                //        if (lb1.SelectedItems[i]== lb1.Items[j])
                //        {
                //            lblIndices.Text += String.Format("\r\n{0}: {1}", j+1, lb1.SelectedItems[i].ToString());
                //        }
                //    }
                //}

                foreach (int indice in lb1.SelectedIndices)
                {
                    lblIndices.Text += String.Format("\r\n{0}",indice);
                }
                

            }
            else
            {
                lblIndices.Text = "Indices:";
            }
        }

        private void borrarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = lb2.Items.Count - 1; i >= 0; i--)  //Clear
            {
                lb2.Items.Remove(lb2.Items[i]);
            }

            
        }

        private void pausarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();

        }

        private void continuarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
