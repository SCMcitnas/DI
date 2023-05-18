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
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            timer1.Interval=1000;
            lblTime.Text = String.Format("{0,2:00}:{1,2:00}", minutos, segundos);

            imagen = Image.FromFile(direccion + "\\Source\\Repos\\DI\\DI_Suf_Ejer9\\play.jpg");
            btnPlay.BackgroundImage = imagen;
            btnPlay.BackgroundImageLayout = ImageLayout.Zoom;
        }

        int intervalo=1000;
        static bool play = false;
        static int segundos = 0;
        static int minutos = 0;
        static int angulo = 0;
        static int segundosGuardados = 0;

        String direccion = Environment.GetEnvironmentVariable("homepath");
        Image imagen;
        

        protected virtual void PlayClick(object sender, EventArgs e)
        {
            if (play)
            {
                
                imagen = Image.FromFile(direccion + "\\Source\\Repos\\DI\\DI_Suf_Ejer9\\play.jpg");
                timer1.Stop();
                btnPlay.BackgroundImage = imagen;
                btnPlay.BackgroundImageLayout = ImageLayout.Zoom;
                play = false;
            }
            else
            {
                imagen = Image.FromFile(direccion + "\\Source\\Repos\\DI\\DI_Suf_Ejer9\\pause.jpg");
                timer1.Start();
                btnPlay.BackgroundImage = imagen;
                btnPlay.BackgroundImageLayout = ImageLayout.Zoom;
                play = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            segundos++;

            if(segundos == segundosGuardados + 1)
            {
                segundosGuardados = segundos;
                angulo= angulo + 6;
                Refresh();
            }


            if (segundos > 59)
            {
                this.DesbordaTiempo(sender, e);
            }

            if (minutos > 59)
            {
                minutos = 0;
            }

            lblTime.Text = String.Format("{0,2:00}:{1,2:00}", minutos, segundos);
        }

        protected virtual void DesbordaTiempo(object sender, EventArgs e)
        {
            if(segundos > 0)
            {
                minutos++;
                segundos = 0;
                segundosGuardados = 0;
                angulo = 0;
                Refresh();
            }
            else
            {
                throw new ArgumentException();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            timer1.Interval = intervalC;
            Graphics g = e.Graphics;
            int grosor = 5;
            Brush br = new SolidBrush(Color.Turquoise);

            g.FillPie(br, 10, 100, 50, 50, 270, angulo);
        }

        [Category("Ejercicio")]
        [Description("Intervalo del timer")]
        public int intervalC
        {
            get
            {
                 return intervalo;
                
            }
            set
            {
                intervalo = value;
                this.Refresh();
            }
        }
    }
}
