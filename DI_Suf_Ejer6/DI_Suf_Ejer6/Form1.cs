using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DI_Suf_Ejer6
{
    public partial class Form1 : Form
    {
        static int marcados = 0;
        List<Button> botones = new List<Button>();
        Guardar guardar = new Guardar();
        Leer leer = new Leer();

        public Form1()
        {
            InitializeComponent(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            Contraseña contrase = new Contraseña();
            DialogResult dr;
            int contador = 3;
            bool acierto = false;
            String contr = "1234";
            
            do
            {
                dr = contrase.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    if (contrase.textBox1.Text.ToUpper() == contr)
                    {
                        acierto=true;
                    }
                    else
                    {
                        contador--;
                        if(contador > 0)
                        {
                            contrase.lblFallo.Text = String.Format("Contraseña incorrecta, te quedan {0} intentos",contador);
                        }
                        else
                        {
                            Environment.Exit(0);
                        }
                    }
                }
            } while (!acierto);


            
            String[] simbolos = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "*", "0", "#" };
            int x=0;
            int y=100;
            int contadorBtn = 0;

            for(int i = 0; i < 12; i++)
            {
                Button bt = new Button();
                contadorBtn++;
                bt.Text = simbolos[i].ToString();
                bt.Location= new Point(x, y);
                bt.Size = new Size(75, 75);
                x = x + 75;
                if (contadorBtn == 3)
                {
                    x = 0;
                    y = y + 75;
                    contadorBtn = 0;
                }

                bt.Click += new System.EventHandler(this.btnClick);
                bt.MouseEnter += new System.EventHandler(this.btnMouseEnter);
                bt.MouseLeave += new System.EventHandler(this.btnMouseLeave);

                botones.Add(bt);
            }

            foreach(Button b in botones)
            {
                this.Controls.Add(b);
            }
        }

        private void btnClick(object sender, EventArgs e)
        {
            if (marcados <= 9)
            {
                ((Button)sender).BackColor = Color.DarkRed;
                txbNumero.Text += ((Button)sender).Text;
                marcados++;
            }
            
        }

        private void btnMouseEnter(object sender,EventArgs e)
        {
            if(((Button)sender).BackColor != Color.DarkRed)
            {
                ((Button)sender).BackColor = Color.Gray;
            }
            
        }

        private void btnMouseLeave(object sender, EventArgs e)
        {
            if (((Button)sender).BackColor != Color.DarkRed)
            {
                ((Button)sender).BackColor = DefaultBackColor;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txbNumero.Text = "";
            foreach(Button b in botones)
            {
                b.BackColor = DefaultBackColor;
            }
            marcados = 0;
        }

        private void grabarNúmeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            guardar.txtbNumero.Text = txbNumero.Text;
            guardar.Show();
        }

        private void verNúmerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            leer.Show();
        }
    }
}
