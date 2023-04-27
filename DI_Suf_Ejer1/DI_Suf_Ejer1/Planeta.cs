using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Suf_Ejer1
{
    public class Planeta : Astro
    {

        private bool gaseoso;
        public List<Astro> Satelites;

        public Planeta(string nombre, double radio, bool gaseoso) : base(nombre, radio)
        {
            //base.Nombre=nombre;
            //base.Radio=radio;
            this.Gaseoso=gaseoso;
            Satelites = new List<Astro>();

        }

        public Planeta() : this("",0,true)
        {
          //  this.Gaseoso=false;
        }

        public Boolean Gaseoso
        {
            set
            {
                gaseoso=value;
            }
            get
            {
                return gaseoso;
            }
        }

    }
}
