using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DI_Suf_Ejer1
{
    public class RadioNegativoException : Exception
    {
        public RadioNegativoException(string mensaje) : base(mensaje)
        {

        }
    }

    public class Astro
    {

        private String nombre;
        private double radio;

        public String Nombre
        { // Trim
            get
            {
                return nombre;
            }

            set
            {
                //if (value.StartsWith(" "))
                //{
                //    value = value.Substring(1);
                //}

                //if (value.EndsWith(" "))
                //{
                //    value = value.Replace(" ", "");
                //}
                nombre = value.ToUpper().Trim();
            }
        }

        public String getNombre(char Separador)
        {
            String nombreSeparado = "";
            for (int i = 0; i < nombre.Length; i++)
            {
                if (i != nombre.Length - 1)
                {
                    nombreSeparado += nombre.ElementAt(i).ToString() + Separador;
                }
                else
                {
                    nombreSeparado += nombre.ElementAt(i).ToString();
                }

            }
            return nombreSeparado;
        }

        public double Radio
        {
            get
            {
                return radio;
            }
            set
            {
                if (radio >= 0)
                {
                    radio = value;
                }
                else
                {
                    throw new RadioNegativoException("El radio es negativo");
                }

            }
        }



        public Astro(string nombre, double radio)
        {
            this.Nombre = nombre;
            this.Radio = radio;
        }

        public override bool Equals(System.Object obj)
        {
            if (obj != null)
            {

                Astro other = obj as Astro;

                if (this.GetType() == obj.GetType())
                {
                    return nombre == other.nombre;
                }

                //if(obj is Planeta && this is Planeta)
                //{
                //    return nombre == other.nombre;
                //}else if(obj is not Planeta && this is not Planeta)
                //{
                //    return nombre == other.nombre;
                //}
            }
            return false;
        }

        public override string ToString()
        {
            return String.Format("El astro {0} tiene un radio de {1:N2}",Nombre,Radio); //String.format o $""
        }
    }
}
