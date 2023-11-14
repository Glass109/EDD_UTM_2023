using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinarioBusqueda
{
    class Program
    {
        static void Main(string[] args)
        {
            ArbolBinario arbol = new ArbolBinario();
            int resp = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("       ARBOLES BINARIOS DE BUSQUEDA");
                Console.WriteLine("1.- Insertar");
                Console.WriteLine("2.- Salir");
                resp = int.Parse(Console.ReadLine());
                switch (resp)
                {
                    case 1:
                        Console.WriteLine("Escribe un valor entero");
                        arbol.Inserta(int.Parse(Console.ReadLine()));
                        break;
                    default: break;
                }
                
            } while (resp != 2);
        }
    }
}
