using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //array 10 posiciones vacío
            string[] pila = new string[10];
                    
            

            bool salida = true;
            int opcion = 0;
            int posicion = 0;
            

            
            inicializarPila(ref pila);

            do
            {
                //generando un array lleno de por referencias estoy
                //pasando el mismo array que he declarado arriba
                Console.WriteLine("INTRODUCE UNA OPCIÓN \n" +
                    "*********************" +
                    "\n 1. Añadir elemento " +
                    "\n 2. Elimina elemento " +
                    "\n 3. Longitud de pila" +
                    "\n 4. Mostrar pila \n " +
                    "5. Salir\n");
                opcion = Convert.ToInt32(Console.ReadLine());


                switch (opcion) 
                {
                    
                case 1:
                        if (pila[pila.Length - 1] != "*")
                        {
                            Console.WriteLine("La pila está llena");
                        }
                        else 
                        {
                        anyadirPila(ref pila, ref posicion);
                        posicion++;
                        }
                        break;
                case 2:
                        if (pila[0] == "*")
                        {
                            Console.WriteLine("la pila esta vacía");
                        }
                        else 
                        { 
                        posicion--;
                        sacarElemento(ref pila, ref posicion);
                        }
                        break;
                case 3:
                        longitudPila(ref pila);
                        break;
                case 4:
                        mostrarPila(ref pila);
                        Console.WriteLine();
                        break;
                case 5:
                        salida = false;
                        break;
                default:
                        Console.WriteLine("Elije una opción correcta");
                        break;
                }
            }
            while (salida);

            Console.WriteLine("HAS TERMINADO EL PROGRAMA");

        }
        // paso por referencia el array pila
        //probar a cambiar el nombre del array en el main
        static void inicializarPila(ref string[] pila)
        {
            for (int i = 0; i < pila.Length; i++)
            {
                pila[i] = "*";
            }

        }

        static void longitudPila(ref string[] pila)
        {
            int longitud = 0;
            for (int i = 0; i < pila.Length; i++) {
                if (pila[i] != "*") {
                    longitud++;
                }
            }  
            Console.Write("la longitud de la pila es: ");
            Console.WriteLine(longitud);
        }
        
        static void anyadirPila(ref string[] pila, ref int posicion) {
            pila[posicion] = "o";
            Console.WriteLine("he añadido un elemento");
        }
        static void sacarElemento(ref string[] pila, ref int posicion)
        {
            pila[posicion] = "*";
            Console.WriteLine("he borrado un elemento");
        }

        static void mostrarPila(ref string[] pila) 
        {
            for (int i = 0; i < pila.Length; i++)
            {
                Console.Write(pila[i]);
            }
        }
    }
}
