using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace DI_Suf_Ejer4
{

    public delegate double MyDelegate(double dato1, double dato2);
    public partial class Form1 : Form
    {
        Hashtable ht = new Hashtable();
        MyDelegate d;
        double dato1;
        double dato2;
        int seg;
        int min;
        RadioButton rb;
        public Form1()
        {
            InitializeComponent();

            ht.Add(rdbSuma.Text, (MyDelegate)((dato1, dato2) => dato1 + dato2));
            ht.Add(rdbResta.Text, (MyDelegate)((dato1, dato2) => dato1 - dato2));
            ht.Add(rdbMulti.Text, (MyDelegate)((dato1, dato2) => dato1 * dato2));
            ht.Add(rdbDivi.Text, (MyDelegate)((dato1, dato2) => dato1 / dato2));

            timer1.Interval = 1000;
            timer1.Start();

            rb = rdbSuma;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                label3.Text = "";
                dato1 = Convert.ToDouble(textBox1.Text);
                dato2 = Convert.ToDouble(textBox2.Text);

                label2.Text = buscarHT(rb.Text);
                
            }
            catch (FormatException ex)
            {
                label3.ForeColor = Color.Red;
                label3.Text = "Datos introducidos invalidos";
            }
        }

        private String buscarHT(String operacion)
        {
            d = (MyDelegate)ht[operacion];
            return String.Format("= {0:N2}", d(dato1,dato2));
        }

        private void cambiarCheck(object sender, EventArgs e)
        {
            rb = (RadioButton)sender;
            label1.Text = rb.Text.ToString();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Quiere cerrar la aplicacion?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)  //arreglar (y el icono)
        {
            if (seg < 59)
            {
                seg++;
            }
            else if(seg >= 59)
            {
                min++;
                seg = 0;
            }else if(min >= 59)
            {
                min = 0;
            }

            this.Text = String.Format("{0:D2}:{1:D2}",min,seg);
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '+':
                    rdbSuma.Checked = true;
                    break;
                case '-':
                    rdbResta.Checked = true;
                    break;
                case '*':
                    rdbMulti.Checked = true;
                    break;
                case '/':
                    rdbDivi.Checked = true;
                    break;
            }
        }
    
    }
}
