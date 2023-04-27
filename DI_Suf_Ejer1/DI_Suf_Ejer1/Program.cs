namespace DI_Suf_Ejer1
{
    internal static class Program
    {
        static void Main()
        {
            List<Astro> astros= new List<Astro>();
            Boolean salir=false;
            int opcion;
            String nombre;
            String nombreL;
            Boolean gaseoso;
            String gaseosoOp;
            int lunas;
            double radio;
            double radioL;
            
            while (!salir)
            {
                try {
                    Console.WriteLine("Escoja una opcion");
                    Console.WriteLine("1- Añade planeta");
                    Console.WriteLine("2- Añade otro astro");
                    Console.WriteLine("3- Mostrar datos");
                    Console.WriteLine("4- Elimina repetidos");
                    Console.WriteLine("5- Salir");
                    opcion = Convert.ToInt32(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Es un planeta gaseoso? (Si/No)");
                            gaseosoOp=Console.ReadLine();
                            if (gaseosoOp.ToUpper() == "SI")
                            {
                                gaseoso = true;
                            }
                            else if (gaseosoOp.ToUpper() == "NO")
                            {
                                gaseoso = false;
                            }
                            else
                            {
                                Console.WriteLine("Resultado no valido");
                                break;
                            }

                            Console.WriteLine("Introduzca el nombre");
                            nombre = Console.ReadLine();

                            Console.WriteLine("Introduzca el radio");
                            radio = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Cuantas lunas tiene");
                            lunas = Convert.ToInt32(Console.ReadLine());

                            Planeta p = new Planeta(nombre, radio, gaseoso);

                            for (int i = 0; i < lunas; i++)
                            {
                                Console.WriteLine("Introduzca el nombre de la luna");
                                nombreL = Console.ReadLine();
                                Console.WriteLine("Introduzca el radio de la luna");
                                radioL = Convert.ToDouble(Console.ReadLine());
                                Astro luna = new Astro(nombreL, radioL);
                                p.Satelites.Add(luna);
                            }
                            
                            astros.Add(p);
                            break;

                        case 2:
                            Console.WriteLine("Introduzca el nombre");
                            nombre = Console.ReadLine();

                            Console.WriteLine("Introduzca el radio");
                            radio = Convert.ToDouble(Console.ReadLine());

                            Astro a = new Astro(nombre, radio);
                            astros.Add(a);

                            break;

                        case 3:
                            for (int i = 0; i < astros.Count; i++)
                            {
                                if (astros[i] is Planeta)
                                {
                                    if (((Planeta)astros[i]).Gaseoso)
                                    {
                                        Console.WriteLine("El planeta " + astros[i].getNombre('.')+" de radio "+ astros[i].Radio+" es gaseoso");
                                    }else
                                    {
                                        Console.WriteLine("El planeta " + astros[i].getNombre('.') + " de radio " + astros[i].Radio + " no es gaseoso");
                                    }
                                    foreach (Astro luna in ((Planeta)astros[i]).Satelites)
                                    {
                                        Console.WriteLine("Una luna del planeta " + astros[i].getNombre('.') + " es " + luna.Nombre+" y tiene un radio de "+luna.Radio);
                                    }
                                }
                                else
                                {
                                    Console.WriteLine(astros[i].ToString());
                                }
                                Console.WriteLine("\n");
                            }
                            break;

                        case 4:

                            for(int j=0; j < astros.Count; j++)
                            {
                                for (int i = 0; i < astros.Count; i++) {
                                    if (astros[i] != astros[j]) {
                                        if (astros[i].Equals(astros[j]))
                                        {
                                            astros.RemoveAt(i);
                                            i = -1;
                                            j = 0;
                                        }
                                    }
                                }
                            }

                            break;

                        case 5:
                            salir = true;
                            break;

                        default:
                            Console.WriteLine("La opcion indicada es incorrecta");
                            break;

                            
                    }
                    Console.WriteLine("\n");

                }
                catch (System.FormatException e)
                {
                    Console.WriteLine("La opcion indicada es incorrecta");
                    Console.WriteLine("\n");
                }
            }
        }
    }
}