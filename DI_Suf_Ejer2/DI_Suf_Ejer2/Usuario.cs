using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Suf_Ejer2
{
    internal class Usuario
    {
        String[] nombres = { "UNO", "UDOS", "TRES" };
        String[] asignaturas = { "AC", "AB", "C", "D" };
        public void init()
        {

            int opcion;
            bool salir=false;

            int maximoAl=0;
            int minimoAl=0;
            Aula aula = new Aula(nombres,asignaturas);
            String alumno;
            String asignatura;
            double resultado;

            while (!salir)
            {
                try
                {
                    Console.WriteLine("Escoja una opcion");
                    Console.WriteLine("1-Visualizar tabla completa");
                    Console.WriteLine("2-Calcular la media de notas de toda la tabla");
                    Console.WriteLine("3-Media alumno");
                    Console.WriteLine("4-Media asingatura");
                    Console.WriteLine("5-Visualizar notas de un alumno");
                    Console.WriteLine("6-Visualizar notas de una asignatura");
                    Console.WriteLine("7-Nota maxima y minima de un alumno");
                    Console.WriteLine("8-Tabla solo aprobados");
                    Console.WriteLine("9-Salir");
                    opcion = Convert.ToInt32(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine(aula.mostrar());
                            break;

                        case 2:
                            Console.WriteLine(String.Format("La media de la tabla es {0:N2}", aula.mediaTot()));
                            break;

                        case 3:
                            resultado = 0;
                            alumno = "";
                            Console.WriteLine(String.Format("Ponga el nombre del alumno ({0})", String.Join(",", nombres)));
                            alumno = Console.ReadLine().ToUpper().Trim();
                            try
                            {
                                resultado = aula.mediaAl(aula.comprobacionIndiceAl(alumno)) / aula.Asignaturas.Length;
                                Console.WriteLine(String.Format("El alumno {0} tiene de media {1:N2}", alumno, resultado));
                            }
                            catch (IndexOutOfRangeException e)
                            {
                                Console.WriteLine(compararNombres(alumno,true));
                            }
                            break;

                        case 4:
                            resultado = 0;
                            asignatura = "";
                            Console.WriteLine(String.Format("Ponga el nombre de la asignatura ({0})", String.Join(",", asignaturas)));
                            asignatura = Console.ReadLine().ToUpper().Trim();
                            try
                            {
                                resultado = aula.mediaAs(aula.comprobacionIndiceAs(asignatura)) / aula.Nombres.Length;
                                Console.WriteLine(String.Format("La asignatura {0} tiene de media {1:N2}", asignatura, resultado));
                            }
                            catch (IndexOutOfRangeException e)
                            {
                                Console.WriteLine(compararNombres(asignatura,false));
                            }
                            break;

                        case 5:
                            alumno = "";
                            Console.WriteLine(String.Format("Ponga el nombre del alumno ({0})", String.Join(",", nombres)));
                            alumno = Console.ReadLine().ToUpper().Trim();
                            
                            try
                            {
                                Console.WriteLine(aula.mostrarNotasAl(aula.comprobacionIndiceAl(alumno)));
                            }catch(IndexOutOfRangeException e)
                            {
                                Console.WriteLine(compararNombres(alumno,true));
                            }
                            break;

                        case 6:
                            asignatura = "";
                            Console.WriteLine(String.Format("Ponga el nombre de la asignatura ({0})", String.Join(",", asignaturas)));
                            asignatura = Console.ReadLine().ToUpper().Trim();
                            
                            try
                            {
                                Console.WriteLine(aula.mostrarNotasAs(aula.comprobacionIndiceAs(asignatura)));
                            }
                            catch (IndexOutOfRangeException e)
                            {
                                Console.WriteLine(compararNombres(asignatura,false));
                            }
                            break;
                
                        case 7:
                            Console.WriteLine(String.Format("Ponga el nombre del alumno ({0})", String.Join(",", nombres)));
                            alumno = Console.ReadLine().ToUpper().Trim();
                            try
                            {
                                aula.notasMaxMin(ref minimoAl, ref maximoAl, aula.comprobacionIndiceAl(alumno));
                                Console.WriteLine(String.Format("La nota minima del alumno {0} es {1}, y su nota maxima es {2}", alumno, minimoAl, maximoAl));
                            }catch(IndexOutOfRangeException e)
                            {
                                Console.WriteLine(compararNombres(alumno,true));
                            }
                            break;

                        case 8:
                            aula.notasAprobadas();
                            foreach (DictionaryEntry ht in aula.HTnotasM)
                            {
                                Console.WriteLine(String.Format("El alumno {0} tiene estas notas aprobadas: {1}", ht.Key, ht.Value.ToString));
                            }
                            break;

                        case 9:
                            salir=true;
                            break;

                        default:
                            Console.WriteLine("La opcion indicada es incorrecta");
                            break;

                            
                    }
                    Console.WriteLine("\n");
                }
                catch (Exception e)
                {
                    Console.WriteLine("La opcion indicada es incorrecta");
                    Console.WriteLine("\n");
                }
            }    
        }

        public String compararNombres(String nombre,bool separar)
        {
            bool parecidos=false;
            String mensaje="Un nombre parecido puede ser:\n";
            if (separar)
            {
                Console.WriteLine("Alumno no encontrado");
                for (int i = 0; i < nombres.Length; i++)
                {
                    if (nombre.StartsWith(nombres[i].First()))
                    {
                        mensaje += nombres[i] + "\n";
                        parecidos = true;
                    }
                }
            }
            else
            {
                Console.WriteLine("Asignatura no encontrada");
                for (int i = 0; i < nombres.Length; i++)
                {
                    if (nombre.StartsWith(asignaturas[i].First()))
                    {
                        mensaje += asignaturas[i] + "\n";
                        parecidos = true;
                    }
                }
            }
            
            if (parecidos)
            {
                return mensaje;
            }
            else
            {
                return "No hay nombres parecidos";
            }
            
        }
    }
}
