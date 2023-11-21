using System;
using System.Collections.Generic;

using System.Text;

namespace BinarioBusqueda
{
    class Program
    {
        static void Main(string[] args)
        {
            ArbolBinario arbol = new ArbolBinario();
            int resp = 0, valor = 0;
            do
            {
                //Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.WriteLine("ARBOLES BINARIOS DE PreOrden");
                Console.WriteLine("1.- Insertar");
                Console.WriteLine("2.- Buscar");
                Console.WriteLine("3.- Eliminar");
                Console.WriteLine("4.- PreOrden");
                Console.WriteLine("5.- Graficar");
                Console.WriteLine("6.- Salir");
                Console.ResetColor();
                resp = int.Parse(Console.ReadLine());
                switch (resp)
                {
                    case 1:
                        Console.WriteLine("Escribe un valor entero");
                        arbol.Inserta(int.Parse(Console.ReadLine()));
                        Console.WriteLine("Elementos en el arbol (PreOrden): ");
                        arbol.MostrarPre();

                        break;
                    case 2:
                        if (!arbol.Vacio())
                        {
                            Console.WriteLine("Escribe un valor entero para buscar");
                            valor = int.Parse(Console.ReadLine());
                            if (arbol.Buscar(valor))
                            {
                                Console.WriteLine($"Valor({valor}) en el arbol");
                            }
                            else
                            {
                                Console.WriteLine("No se encuentra el valor en el arbol");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Arbol vacio");
                        }
                        break;
                    case 3:
                        if (!arbol.Vacio())
                        {
                            Console.WriteLine("Escribe un valor entero para Eliminar");
                            valor = int.Parse(Console.ReadLine());
                            arbol.Eliminar(valor);
                            Console.WriteLine("Elementos en el arbol (PreOrden): ");
                            if (!arbol.Vacio())
                            {
                                arbol.MostrarPre();
                            }

                        }
                        else
                        {
                            Console.WriteLine("Arbol vacio");
                        }
                        break;
                    case 4:
                        if (!arbol.Vacio())
                        {
                            arbol.MostrarPre();
                        }
                        else
                        {
                            Console.WriteLine("Arbol vacio");
                        }
                        break;
                    case 5:
                        arbol.Graficar();
                    break;
                    default: break;
                }
            } while (resp != 6);
        }
    }
}
