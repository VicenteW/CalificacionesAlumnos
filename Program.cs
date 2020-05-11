using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CadenaMKarla
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el tamaño de su arreglo");
            int tamaño = 10000;
            int[] arreglo = new int[tamaño];
            int opc;
            Program cadena = new Program();
            for(int i = 0; i<10000; i++)
            {
                cadena.Insertar(arreglo, tamaño);
            }
            do
            {
                Console.WriteLine("Seleccione una opcion \n 1) Insertar un nuevo numero al arreglo \n 2) Eliminar un numero del arreglo \n 3) Ver el arreglo \n 4) Buscar posicion\n 0) Salir");
                opc = Convert.ToInt32(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        cadena.Insertar(arreglo, tamaño);
                        break;

                    case 2:
                        cadena.Eliminar(arreglo, tamaño);
                        break;

                    case 3:
                        cadena.Mostrar(arreglo, tamaño);
                        break;

                    case 4:
                        cadena.BusquedaSecuencial(arreglo, tamaño);
                        break;

                    case 0:
                        break;
                }
            } while (opc != 0);
        }


        public void Insertar(int[] arreglo, int tamaño)
        {
            int i = 0;
            bool bandera = false;
            Random rnd = new Random();
            do
            {
                if (arreglo[i] == 0)
                {
                    arreglo[i] = rnd.Next(1, 100);
                    Console.WriteLine("Numero " + arreglo[i] + " a sido agregado");
                    bandera = true;
                }else
                {
                    if (i + 1 == tamaño)
                    {
                        Console.WriteLine("SU ARREGLO ESTA LLENO");
                        bandera = true;
                    }
                }
                i++;
            } while (bandera == false);
        }

        

        public void Eliminar(int[] arreglo, int tamaño)
        {
            Console.WriteLine("Seleccione el numero que desea eliminar");
            for(int i=0; i<tamaño; i++)
            {
                Console.WriteLine(i + 1 + ") " + arreglo[i]);
            }
            int num_eli = Convert.ToInt32(Console.ReadLine());
            arreglo[num_eli - 1] = 0;
            Console.WriteLine("Numero eliminado");
        }

        public void Mostrar(int[] arreglo, int tamaño)
        {
            Console.WriteLine("A continuación se muestra su arreglo:");
            for (int i = 0; i < tamaño; i++)
            {
                Console.WriteLine(i + 1 + ") " + arreglo[i]);
            }
        }

        public void BusquedaSecuencial(int[] arreglo, int tamaño)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            Console.WriteLine("¿Que numero desea buscar?");
            int num_bus = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            bool bandera = false;
            do
            {
                if (arreglo[i] == num_bus)
                {
                    Console.Write("Su numero esta en la posición: ");
                    Console.WriteLine(i+1);
                    bandera = true;
                }
                else
                {
                    if (i + 1 == tamaño)
                    {
                        Console.WriteLine("Ese numero no se encuentra en la cadena");
                        bandera = true;
                    }
                }
                i++;
            } while (bandera == false);
            stopWatch.Stop();
            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;

            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
        }

    }
}