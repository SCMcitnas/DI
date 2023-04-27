using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Suf_Ejer2
{
    internal class Aula
    {
        Random random = new Random();
        private int[,] notas;
        String[] nombres;
        String[] asignaturas;
        

        public String tabla="";
        String tablaC = "";
        String iniceTabla;
        double media = 0;
        public bool encontrado = false;
        public bool contador = true;
        public Hashtable HTnotasM;

        private int[,] Notas
        {
            get
            {
                return notas;
            }

            set
            {
                notas = value;
            }
        }

        public String[] Nombres
        {
            get { return nombres; }

            set { nombres = value; }
        }

        public String[] Asignaturas
        {
            get { return asignaturas; }
            set
            {
                asignaturas = value;
            }
        }

        public Aula(String[] nombres, String[] asignaturas)
        {
            this.Nombres = nombres;
            this.Asignaturas = asignaturas;
            notas = new int[nombres.Length, asignaturas.Length];
            for (int i = 0; i < nombres.Length; i++)
            {
                for(int j = 0; j < asignaturas.Length; j++)
                {
                    notas[i,j] = random.Next(0,11);
                }
            }
        }

        public String mostrar()  //TODO usar cadenas de formato no tabuiladores y esto a Menu
        {
            tablaC = "";
            for(int i = 0; i < Nombres.Length; i++)
            {
                iniceTabla = String.Format("{0,7}","");
                if (i == 0)
                {
                    for(int m=0; m < Asignaturas.Length; m++)
                    {
                        iniceTabla += String.Format("{0,5}",Asignaturas[m]);
                    }
                    tablaC=String.Format("{0}\n",iniceTabla);

                }
                
                tabla = "";

               tabla = String.Format("{0,7}", Nombres[i]);
                for (int j = 0; j < Asignaturas.Length; j++)
                {
                   
                    tabla += String.Format("{0,5}", Notas[i, j]);
                }

                tablaC += tabla + "\n";
            }
            return tablaC;
        }

        public double mediaTot()
        {
            this.media = 0;
            int divisor = notas.Length;// Nombres.Length*Asignaturas.Length;
            for(int i=0; i<Nombres.Length; i++)
            {
                for(int j=0; j<Asignaturas.Length; j++)
                {
                    this.media = this.media+notas[i, j];
                }
            }
            this.media = this.media / divisor;
            return this.media;
        }

        public double mediaAl(int indice)
        {
            this.media = 0;

            for (int j = 0; j < Asignaturas.Length; j++)
            {
                this.media = this.media + notas[indice, j];  
            }

            return this.media;
        }

        public double mediaAs(int indice)
        {
            this.media = 0;

            for (int j = 0; j < Nombres.Length; j++)
            {
                this.media = this.media + Notas[j,indice];
            }

            return this.media;

        }

        public String mostrarNotasAs(int indice)
        {

                iniceTabla = "";
                tabla = "";

                tabla = String.Format("{0,7}{1,5}\n", "", Asignaturas[indice]);
                for (int j = 0; j < Nombres.Length; j++)
                {
                    tabla += String.Format("{0,7}{1,5}\n", Nombres[j], Notas[j, indice]);
                }

                return tabla;
        }

        public String mostrarNotasAl(int indice)
        {
                tablaC = "";
                iniceTabla = String.Format("{0,7}", "");
                tabla = String.Format("{0,7}", Nombres[indice]);
                for (int i = 0; i < Asignaturas.Length; i++)
                {
                    
                    if (i == 0)
                    {
                        for (int m = 0; m < Asignaturas.Length; m++)
                        {
                            iniceTabla += String.Format("{0,5}", Asignaturas[m]);
                        }
                    }

                    tabla += String.Format("{0,5}", Notas[indice, i]);
                }
                tablaC = iniceTabla + "\n" + tabla;
                return tablaC;
                
        }

        public void notasAprobadas()
        {
            HTnotasM = new Hashtable();
            
            for (int i=0;i< Nombres.Length; i++)
            {
                int[] vector= new int[Asignaturas.Length];
                int[] total = new int[Asignaturas.Length];
                int contador=0;
                int contadorVector = 0;
                
                for(int j=0; j< Asignaturas.Length; j++)
                {
                    if (Notas[i, j] >= 5)
                    {
                        vector[j]=Notas[i, j];
                        total[j] = Notas[i,j];
                    }
                }

                for(int j=0; j< vector.Length; j++)
                {
                    if (vector[j] != 0)
                    {
                        vector[contador]=vector[j];
                    }
                    else
                    {
                        contador++;
                    }
                }
                vector = new int[Asignaturas.Length-contador];
                
                for(int j=0; j< total.Length; j++)
                {
                    if(total[j] != 0)
                    {
                        vector[contadorVector]=total[j];
                        contadorVector++;
                    }
                }

                try
                {
                    HTnotasM.Add(Nombres[i],  vector);//vector
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e);
                }
            }
            
        }

        public void notasMaxMin(ref int min, ref int max, int indice)
        {
            min = Notas[indice, 0];
            max = Notas[indice, 0];
            for (int j = 0; j < Asignaturas.Length; j++)
            {
                if (notas[indice, j] > max)
                {
                    max = Notas[indice, j];
                }
                else if (Notas[indice, j] < min)
                {
                    min = Notas[indice, j];
                }
            }
        }

        public int comprobacionIndiceAl(String variable)
        {
            for(int i = 0; i < Nombres.Length; i++)
            {
                if (Nombres[i]==variable)
                {
                    return i;
                }
            }
            return -1;
        }

        public int comprobacionIndiceAs(String variable)
        {
            for (int i = 0; i < Asignaturas.Length; i++)
            {
                if (Asignaturas[i] == variable)
                {
                    return i;
                }
            }
            return -1;
        }

    }
}
