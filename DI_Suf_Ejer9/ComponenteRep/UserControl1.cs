using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComponenteRep
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();

            angulo = segundos * 6;
            Refresh();

            lblTime.Text = String.Format("{0,2:00}:{1,2:00}", minutos, segundos);
            btnPlay.BackgroundImage = ComponenteRep.Properties.Resources.play;
            btnPlay.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private bool play = false;
        private int segundos = 0;
        private int minutos = 0;
        private int angulo = 0;

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (play)
            {
                btnPlay.BackgroundImage = ComponenteRep.Properties.Resources.play;
                btnPlay.BackgroundImageLayout = ImageLayout.Zoom;
                play = false;
            }
            else
            {
                btnPlay.BackgroundImage= ComponenteRep.Properties.Resources.pause;
                btnPlay.BackgroundImageLayout = ImageLayout.Zoom;
                play = true;
            }

            OnPlayClick(EventArgs.Empty);
        }


        [Category("Ejercicio")]
        [Description("Al hacer click en el boton play se activa el evento")]
        public event EventHandler PlayClick;

        protected virtual void OnPlayClick(EventArgs e)
        {
            if (PlayClick != null)
            {
                PlayClick(this, e);
            }
        }


        [Category("Ejercicio")]
        [Description("Segundos del reproductor")]
        public int SS
        {
            set
            {
                if(value >= 0)
                {
                    if (value > 59)
                    {
                        OnDesbordaTiempo(EventArgs.Empty);
                        segundos = value % 60;
                    }
                    else
                    {
                        segundos = value;

                    }
                    angulo = segundos * 6;
                    Refresh();


                    lblTime.Text = String.Format("{0,2:00}:{1,2:00}", minutos, segundos);
                }
                else
                {
                    throw new ArgumentException();
                }

            }
            get
            {
                return segundos;
            }
        }

        [Category("Ejercicio")]
        [Description("Minutos del reproductor")]
        public int MM
        {
            set
            {
                if(value >= 0)
                {
                    if (value > 59)
                    {
                        minutos=0;
                    }
                    else
                    {
                        minutos = value;
                    }


                    lblTime.Text = String.Format("{0,2:00}:{1,2:00}", minutos, segundos);
                }
                else
                {
                    throw new ArgumentException();
                }
            }
            get
            {
                return minutos;
            }
        }

        [Category("Ejercicio")]
        [Description("Evento ejecutado cuando se completa un minuto")]
        public event EventHandler DesbordaTiempo;

        protected virtual void OnDesbordaTiempo(EventArgs e)
        {
            if(DesbordaTiempo != null)
            {
                DesbordaTiempo(this, e);
            }
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            int grosor = 5;
            Brush br = new SolidBrush(Color.Turquoise);

            g.FillPie(br, 10, 100, 50, 50, 270, angulo);
        }


        
    }
}
