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

namespace DI_Suf_Ejer3
{
    public partial class Form1 : Form  // Accept button cuandop cambia a imagen, borrar imagen si no es valida
    {
 
        public Form1()
        {
            InitializeComponent();
            this.Cursor = Cursors.Hand;
            textBoxImg.Text = "C:\\Users\\Santiago\\Source\\Repos\\DI_Suf_Ejer3\\ejem.png";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            else if (e.KeyCode == Keys.T)
            {
                this.Text = "Colores e Imagenes";
            }
        }


        private void cambioFondo(object sender, EventArgs e)
        {
            try
            {
                label1.Text = "";
                this.BackColor = Color.FromArgb(Int32.Parse(textBoxR.Text), Int32.Parse(textBoxG.Text), Int32.Parse(textBoxB.Text));
            }
            catch (ArgumentException ex)
            {
                if (this.BackColor == Color.Red)
                {
                    label1.ForeColor = Color.White;
                    label1.Text = "Ha insertado un RGB fuera de rango (0-255), porfavor intentelo de nuevo";
                }
                else
                {
                    label1.Text = "Ha insertado un RGB fuera de rango (0-255), porfavor intentelo de nuevo";
                }

            }
            catch (FormatException ex)
            {
                if (this.BackColor == Color.Red)
                {
                    label1.ForeColor = Color.White;
                    label1.Text = "Ha insertado un caracter que no corresponde a un numero, intentelo de nuevo";
                }
                else
                {
                    label1.Text = "Ha insertado un caracter que no corresponde a un numero, intentelo de nuevo";
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("¿Quiere cerrar la aplicacion?","Cerrar",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel=true;
            }
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
                this.Text = "Colores e Imagenes";
        }

        private void moveComponentes(object sender, MouseEventArgs e)
        {
            int x=0;
            int y=0;
            Type type = sender.GetType();

            if (sender !=this) // Acortar
            {
                x = e.Location.X + ((Control)sender).Location.X;
                y = e.Location.Y + ((Control)sender).Location.Y;   
            }
    
            else
            {
                x = e.X;
                y = e.Y;
            }

            this.Text = "X: " + x + " Y: " + y;
        }

        private void mouseEnter(object sender, EventArgs e)
        {
           ((Button)sender).BackColor = Color.Pink;
        }

        private void mouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = DefaultBackColor;
        }


        private void btnImagen_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.ImageLocation = textBoxImg.Text;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch(FileNotFoundException ex)
            {
                pictureBox1 = null;
                if (this.BackColor == Color.Red)
                {
                    label2.ForeColor = Color.White;
                    label2.Text = "El path de la imagen no ha sido encontrado";
                }
                else
                {
                    label2.ForeColor = Color.Red;
                    label2.Text = "El path de la imagen no ha sido encontrado";
                }
            }
            
        }

        private void enterTxtB(object sender, EventArgs e)
        {
            if(sender== textBoxImg)
            {
                AcceptButton = btnImagen;
            }else if(sender == textBoxR || sender == textBoxG || sender == textBoxB)
            {
                AcceptButton = btnColor;
            }
        }
    }
}
