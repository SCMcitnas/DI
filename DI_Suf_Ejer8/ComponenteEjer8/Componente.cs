using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            Graphics g = pe.Graphics;
            GraphicsPath path = new GraphicsPath();
            RectangleF rect = new RectangleF(0,0, this.Width, this.Height);
            

            path.AddRectangle(rect);
            int grosor = 0; //Grosor de las líneas de dibujo
            int offsetX = 0; //Desplazamiento a la derecha del texto
            int offsetY = 0; //Desplazamiento hacia abajo del texto
                             // Altura de fuente, usada como referencia en varias partes
            int h = this.Font.Height;
            PathGradientBrush x;
            
            switch (Gradiente)
            {
                case eGradiente.Si:
                    x = new PathGradientBrush(path);
                    Color[] colors = { Color.Blue, Color.Green};
                    x.SurroundColors = colors;
                    pe.Graphics.FillRectangle(x, rect);

                    break;

                case eGradiente.No:
                    x = new PathGradientBrush(path);
                    Color[] color = { this.BackColor};
                    x.SurroundColors = color;
                    pe.Graphics.FillRectangle(x, rect);
                    break;
            }

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
                    String direccion = Environment.GetEnvironmentVariable("homepath");
                    Image image = Image.FromFile(direccion+ "\\Source\\Repos\\DI\\DI_Suf_Ejer8\\tree-736885_1280.jpg");
                    
                    pe.Graphics.DrawImage(image, 0,0,this.Width/5,this.Height);
                    offsetX = this.Width / 5;
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
            }
            get
            {
                return gradiente;
            }
        }

        [Category("Ejercicio")]
        [Description("Se lanza cuando se pulsa el componente")]
        public event EventHandler ClickEnMarca;

        protected virtual void OnClickMarca(object sender, EventArgs e)
        {
            if(ClickEnMarca != null){
                
            }
        }
    }
}
