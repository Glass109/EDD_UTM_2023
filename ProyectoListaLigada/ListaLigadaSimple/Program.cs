using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaLigadaSimple
{
    class Program
    {
        static void Main(string[] args)
        {
            int resp = 0;
            LSS lista = new LSS();

            while (resp != 10) 
            {
                Console.Clear();
                Console.WriteLine("1.- Ver lista");
                Console.WriteLine("2.- Buscar elemento");
                Console.WriteLine("3.- Insertar Inicio");
                Console.WriteLine("4.- Insertar Final");
                Console.WriteLine("5.- Eliminar inicio");
                Console.WriteLine("6.- Eliminar Final");
                Console.WriteLine("7.- Numero de Elementos");
                Console.WriteLine("8.- Ordenar (Burbuja)");
                Console.WriteLine("9.- Invertir");
                Console.WriteLine("10.- Salir de la aplicación \n\n");
                Console.Write("\nSu selección: ");
                resp = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (resp) 
                {
                    case 1:
                        Console.WriteLine("Elementos de la lista");
                        lista.mostrarLista();
                        Console.WriteLine();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("Escribe el valor entero a buscar:");
                        if (lista.buscarElemento(int.Parse(Console.ReadLine())))
                            Console.WriteLine("Elemento encontrado");
                        else
                            Console.WriteLine("Elemento No encontrado");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("Escriba un elemento entero para insertar al inicio");
                        lista.insertarInicio(int.Parse(Console.ReadLine()));
                        break;
                    case 4:
                        Console.WriteLine("Escriba un elemento entero para insertar al final");
                        lista.insertarFinal(int.Parse(Console.ReadLine()));
                        break;
                    case 5:
                        if (lista.eliminarInicio())
                            Console.WriteLine("Elemento eliminado");
                        else
                            Console.WriteLine("Lista vacía, no es posible eliminar");
                        Console.ReadKey();
                        break;
                    case 6:
                        if (lista.eliminarFinal())
                            Console.WriteLine("Elemento eliminado");
                        else
                            Console.WriteLine("Lista vacía, no es posible eliminar");
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.WriteLine("Número de elementos = " + lista.numeroElementos());
                        Console.ReadKey();
                        break;
                    case 8:
                        lista.Burbuja();
                        Console.WriteLine("Lista ordenada de menor a mayor");
                        Console.ReadKey();
                        break;
                    case 9:
                        lista.Invertir();
                        Console.WriteLine("El orden de los elementos ha cambiado");
                        Console.ReadKey();
                        break;
                    case 10:
                        break;
                    default:
                        Console.WriteLine("Opción no válida...");
                        break;
                }
                if (resp != 10) Console.ReadKey();

            }
        }
    }
}
