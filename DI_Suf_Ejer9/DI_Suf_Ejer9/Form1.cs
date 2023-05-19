using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DI_Suf_Ejer9
{
    public partial class Form1 : Form
    {
        private bool play = false;

        public Form1()
        {
            InitializeComponent();
            for(int i = 100; i <= 10000; i = i + 100)
            {
                comboBox1.Items.Add(i);
            }

            comboBox1.SelectedIndex = 0;
            
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            timer1.Interval = Convert.ToInt16(comboBox1.SelectedItem.ToString());
            userControl11.Refresh();
        }

        private void userControl11_DesbordaTiempo(object sender, EventArgs e)
        {

            userControl11.MM++;
            userControl11.Refresh();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            userControl11.SS++;
        }

        private void userControl11_PlayClick(object sender, EventArgs e)
        {
            if (play)
            {
                timer1.Stop();
                play = false;
            }
            else
            {
                timer1.Start();
                play = true;
            }
        }
    }
}
