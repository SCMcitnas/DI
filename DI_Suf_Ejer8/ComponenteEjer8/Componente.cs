using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Interop;

namespace ComponenteEjer8
{
    public partial class Componente : Control
    {

        public enum eMarca
        {
            Nada,
            Cruz,
            Circulo,
            Imagen
        }

        public enum eGradiente
        {
            Si,
            No
        }

        public Componente()
        {
            InitializeComponent();
        }

        int grosor;
        int h;

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            Graphics g = pe.Graphics;
            GraphicsPath path = new GraphicsPath();
            RectangleF rect = new RectangleF(0,0, this.Width, this.Height);
            Image image=null;


            path.AddRectangle(rect);
            grosor = 0; //Grosor de las líneas de dibujo
            int offsetX = 0; //Desplazamiento a la derecha del texto
            int offsetY = 0; //Desplazamiento hacia abajo del texto
                             // Altura de fuente, usada como referencia en varias partes
            h = this.Font.Height;
            PathGradientBrush x;
            
                    x = new PathGradientBrush(path);
                    Color[] colors = { Color1, Color2};
            switch (Gradiente)
            {
                case eGradiente.Si:
                    //x.SurroundColors = colors;
                    //pe.Graphics.FillRectangle(x, rect);

                    break;

                case eGradiente.No:
                    //x = new PathGradientBrush(path);
                      colors = new Color[] { this.BackColor};
                    break;
            }
                    x.SurroundColors = colors;
                    pe.Graphics.FillRectangle(x, rect);

            //Esta propiedad provoca mejoras en la apariencia o en la eficiencia
            // a la hora de dibujar
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            //Dependiendo del valor de la propiedad marca dibujamos una
            //Cruz o un Círculo
            switch (Marca)
            {
                case eMarca.Circulo:
                    grosor = 3;
                    g.DrawEllipse(new Pen(Color.Green, grosor), grosor, grosor, h, h);
                    offsetX = h + grosor;
                    offsetY = grosor;
                    break;
                case eMarca.Cruz:
                    grosor = 3;
                    Pen lapiz = new Pen(Color.Red, grosor);
                    g.DrawLine(lapiz, grosor, grosor, h, h);
                    g.DrawLine(lapiz, h, grosor, grosor, h);
                    offsetX = h + grosor;
                    offsetY = grosor / 2;
                    //Es recomendable liberar recursos de dibujo pues se
                    //pueden realizar muchos y cogen memoria
                    lapiz.Dispose();
                    break;
                case eMarca.Imagen:
                    
                    try
                    {
                        String direccion = Environment.GetEnvironmentVariable("homepath");
                        image = PathImg;
                        grosor = h * 2;
                        pe.Graphics.DrawImage(image, 0, 0, grosor, h);
                        offsetX = grosor/5;
                    }
                    catch(FileNotFoundException ex)   
                    {
                        grosor = 0;
                    }
                    catch(ArgumentNullException ex)
                    {
                        grosor = 0;
                    }
                    break;
            }

            //Finalmente pintamos el Texto; desplazado si fuera necesario
            SolidBrush b = new SolidBrush(this.ForeColor);
            g.DrawString(this.Text, this.Font, b, offsetX + grosor, offsetY);
            Size tam = g.MeasureString(this.Text, this.Font).ToSize();
            this.Size = new Size(tam.Width + offsetX + grosor, tam.Height + offsetY * 2);
            b.Dispose();
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            this.Refresh();
        }

        private eMarca marca = eMarca.Nada;
        [Category("Appearance")]
        [Description("Indica el tipo de marca que aparece junto al texto")]
        public eMarca Marca
        {
            set
            {
                marca = value;
                this.Refresh();
            }
            get
            {
                return marca;
            }
        }

        private eGradiente gradiente = eGradiente.No;
        [Category("Appearance")]
        [Description("Indica el tipo de fondo del componente")]
        public eGradiente Gradiente
        {
            set
            {
                gradiente = value;
                this.Refresh();
            }
            get
            {
                return gradiente;
            }
        }

        private Color color1 = Color.Red;
        [Category("Appearance")]
        [Description("Indica un color del gradiante")]
        public Color Color1
        {
            set
            {
                color1 = value;
                this.Refresh();
            }
            get
            {
                return color1;
            }
        }

        private Color color2 = Color.Blue;
        [Category("Appearance")]
        [Description("Indica otro color del gradiante")]
        public Color Color2
        {
            set
            {
                color2 = value;
                this.Refresh();
            }
            get
            {
                return color2;
            }
        }

        private Image path = Image.FromFile(Environment.GetEnvironmentVariable("homepath")+"\\Source\\Repos\\DI\\DI_Suf_Ejer8\\imagen.jpg");
        [Category("Appearance")]
        [Description("Indica el path de la imagen de la marca")]
        public Image PathImg
        {
            set
            {
                path = value;
                this.Refresh();
            }
            get
            {
                return path;
            }
        }


        [Category("Ejercicio")]
        [Description("Se lanza cuando se pulsa el componente")]
        public event EventHandler ClickEnMarca;

        protected virtual void OnClickMarca(EventArgs e)
        {
            if(ClickEnMarca != null){
                ClickEnMarca(this, e);
            }
        }

        private void EtiquetaAviso_MouseClick(object sender, MouseEventArgs e)
        {
            if(marca != eMarca.Nada && e.X<grosor+h && e.Y<h)
            {
                OnClickMarca(EventArgs.Empty);
            }
        }
    }
}
