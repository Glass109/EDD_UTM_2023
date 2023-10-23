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

                if (int.TryParse(Console.ReadLine(), out resp)) // Intenta parsear el valor ingresado
                {
                    Console.WriteLine();
                    switch (resp)
                    {
                        case 1:
                            Console.WriteLine("Elementos de la lista");
                            lista.mostrarLista();
                            Console.WriteLine("\nPresione enter para continuar");
                            break;
                        case 2:
                            try
                            {
                                Console.WriteLine("Escribe el valor entero a buscar:");
                                int elementoBuscado = int.Parse(Console.ReadLine());
                                int posicionEncontrada = lista.buscarElemento(elementoBuscado);
                                lista.mostrarLista();
                                if (posicionEncontrada != -1)
                                {
                                    Console.WriteLine("Elemento encontrado en la posición: " + posicionEncontrada);
                                }
                                else
                                {
                                    Console.WriteLine("Elemento No encontrado");
                                }
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero.");
                            }
                            Console.WriteLine("\nPresione enter para continuar");
                            break;
                        case 3:
                            try
                            {
                                Console.WriteLine("Escriba un elemento entero para insertar al inicio");
                                lista.insertarInicio(int.Parse(Console.ReadLine()));
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero.");
                            }
                            break;
                        case 4:
                            try
                            {
                                Console.WriteLine("Escriba un elemento entero para insertar al final");
                                lista.insertarFinal(int.Parse(Console.ReadLine()));
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero.");
                            }
                            break;
                        case 5:
                            try
                            {
                                if (lista.eliminarInicio())
                                    Console.WriteLine("Elemento eliminado");
                                else
                                    Console.WriteLine("Lista vacía, no es posible eliminar");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Se produjo una excepción: " + ex.Message);
                            }
                            lista.mostrarLista();
                            Console.WriteLine("\nPresione enter para continuar");
                            break;
                        case 6:
                            try
                            {
                                if (lista.eliminarFinal())
                                    Console.WriteLine("Elemento eliminado");
                                else
                                    Console.WriteLine("Lista vacía, no es posible eliminar");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Se produjo una excepción: " + ex.Message);
                            }
                            lista.mostrarLista();
                            Console.WriteLine("\nPresione enter para continuar");
                            break;
                        case 7:
                            Console.WriteLine("Número de elementos = " + lista.numeroElementos());
                            lista.mostrarLista();
                            Console.WriteLine("\nPresione enter para continuar");
                            break;
                        case 8:
                            try
                            {
                                lista.Burbuja();
                                Console.WriteLine("Lista ordenada de menor a mayor");
                                lista.mostrarLista();
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Se produjo una excepción: " + ex.Message);
                            }
                            Console.WriteLine("\nPresione enter para continuar");
                            break;
                        case 9:
                            try
                            {
                                lista.Invertir();
                                Console.WriteLine("El orden de los elementos ha cambiado");
                                lista.mostrarLista();
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Se produjo una excepción: " + ex.Message);
                            }
                            Console.WriteLine("\nPresione enter para continuar");
                            break;
                        case 10:
                            break;
                        default:
                            Console.WriteLine("Opción no válida...");
                            break;
                    }
                    if (resp != 10) Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Por favor, ingrese una opcion valida.");
                    Console.ReadKey();
                }
            }
        }
    }
}