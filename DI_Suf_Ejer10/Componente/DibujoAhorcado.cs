using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componente
{
    public partial class DibujoAhorcado: UserControl
    {
        public DibujoAhorcado()
        {
			InitializeComponent();
			Refresh();
		}

		private int errores;

		[Category("Ejercicio")]
		[Description("Errores en el juego")]
		public int Errores { 

			get { 
				return errores; 
			} 
			set {


                errores = value;

                if (value <= 7)
				{
                    OnCambiaError(EventArgs.Empty);
                }
				else
				{
                    OnAhorcado(EventArgs.Empty);
                }

			} 
		}

		[Category("Ejercicio")]
		[Description("Cambia el numero de errores")]
		public event EventHandler CambiaError;

		protected virtual void OnCambiaError(EventArgs	e)
		{
			if(CambiaError != null)
			{
				CambiaError(this, e);
			}
		}

		[Category("Ejercicio")]
		[Description("Evento cuando se pierde en el juego")]
		public event EventHandler Ahorcado;

		protected virtual void OnAhorcado(EventArgs e)
		{
			if(Ahorcado != null)
			{
				Ahorcado(this, e);
			}
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);

			Graphics g = e.Graphics;
			int grosor=2;
			Brush br = new SolidBrush(Color.Black);
			Pen pen = new Pen(br, grosor);

			switch (errores)
			{
				case 1:
					g.DrawLine(pen, this.Width / 5, this.Height - this.Height / 10, this.Width / 3, this.Height - this.Height / 10);
					g.DrawLine(pen, this.Width / 4, this.Height - this.Height / 10, this.Width / 4, this.Height / 4);
					break;
				case 2:
					g.DrawLine(pen, this.Width / 4, this.Height / 4, this.Width - this.Width / 3, this.Height / 4);
					goto case 1;
					break;
				case 3:
					g.DrawLine(pen, this.Width - this.Width / 3, this.Height / 4, this.Width - this.Width / 3, this.Height / 3);
					goto case 2;
					break;
				case 4:
					g.DrawEllipse(pen,new RectangleF(this.Width/2, this.Height/3, this.Width/4, this.Height / 3 - this.Height/10));
					goto case 3;
					break;
				case 5:
					g.DrawLine(pen, this.Width - this.Width / 3, this.Height / 2, this.Width - this.Width / 3, this.Height / 2 +this.Height/3);
					goto case 4;
					break;
				case 6:
					g.DrawLine(pen, this.Width - this.Width / 2, this.Height / 2+ this.Height/5, this.Width - this.Width / 4, this.Height / 2 + this.Height / 5);
                    
                    goto case 5;
					break;
				case 7:
                    g.DrawLine(pen, this.Width - this.Width / 3, this.Height / 2 + this.Height / 3, this.Width - this.Width / 2, this.Height / 2 + this.Height / 4);
                    g.DrawLine(pen, this.Width - this.Width / 3, this.Height / 2 + this.Height / 3, this.Width - this.Width / 6, this.Height / 2 + this.Height / 4);
                    goto case 6;
					break;

				default:
					break;
			}

			
		}
	}
}
