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
        static int intervalo=0;
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
            intervalo = Convert.ToInt16(comboBox1.SelectedItem.ToString());
            userControl11.intervalC = intervalo;
            userControl11.Refresh();
        }
    }
}
