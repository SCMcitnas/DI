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

namespace DI_Suf_Ejer10
{
	public partial class Form1 : Form
	{

		String palabraE="";
		Random random = new Random();
		String[] palabras;
		List<Label> labels= new List<Label>();
		List<String> letasU = new List<string>();

		bool start= false;
		bool ganar;
		bool repetida;

		public Form1()
		{
			InitializeComponent();

			try
			{
				String path = Environment.ExpandEnvironmentVariables("%APPDATA%") + "\\palabras.txt";
				using (StreamReader sr = new StreamReader(path))
				{
					palabras = sr.ReadToEnd().Split(',');
				}
			}
			catch (Exception)
			{
				Environment.Exit(0);
			}

			letasU.Add("");
		}

		private void btn_inicio_Click(object sender, EventArgs e)
		{

			lbl_Win.Text = "";

			try
			{
				if (labels != null)
				{
					foreach (Label label in labels)
					{
						this.Controls.Remove(label);
					}
				}
			}
			catch(Exception ex)
			{

			}
			

			int num = random.Next(0,palabras.Length);
			palabraE = palabras[num];
			labels = new List<Label>();
			letasU = new List<String>();

			lbl_letrasUsadas.Text = "Letras usadas: ";

			dibujoAhorcado1.Errores = 0;
			

			int puntoX = 50;

			for (int i =0; i<palabraE.Length;i++)
			{
				Label label = new Label();
				label.Text = "_";
				label.Location = new Point(puntoX,200);
				label.Size = new Size(25,25);
				label.Font= new Font(new FontFamily("Microsoft Sans Serif"),16);

				labels.Add(label);

				puntoX = puntoX + 50;
			}

			foreach(Label label in labels)
			{
				this.Controls.Add(label);
			}

			start = true;
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			repetida = false;

            foreach (String letra in letasU)
            {
                if (textBox1.Text == letra)
                {
                    repetida = true;
                }
            }

            if (!repetida && start)
            {
                letasU.Add(textBox1.Text);
                lbl_letrasUsadas.Text += textBox1.Text + ", ";
            }



            if (textBox1.Text != null && textBox1.Text != "" && start && !repetida)
			{
				if (palabraE.Contains(textBox1.Text))
				{
					try
					{
						ganar = true;

						for (int i = 0; i < palabraE.Length; i++)
						{
							if (palabraE[i].ToString() == textBox1.Text)
							{
								labels[i].Text = textBox1.Text;
							}
						}

					}
					catch (Exception ex)
					{

					}
				}
				else
				{
					dibujoAhorcado1.Errores++;
				}
            }

			

			foreach(Label label in labels)
			{
				if (label.Text == "_")
				{
					ganar = false;
				}
			}

			if (ganar)
			{
                start = false;
                lbl_Win.Text = "Ganaste!! La palabra era " + palabraE;
            }

		}

		private void dibujoAhorcado1_CambiaError(object sender, EventArgs e)
		{
            dibujoAhorcado1.Refresh();
        }

		private void dibujoAhorcado1_Ahorcado(object sender, EventArgs e)
		{
			start = false;

            lbl_Win.Text = "Lo siento, te has ahorcado";
        }
	}
}
