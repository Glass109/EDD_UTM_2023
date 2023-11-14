using System;

namespace BinarioBusqueda;

internal static class Program
{
    public static void Main(string[] args)
    {
        BinaryTree tree = new(); //Crear arbol binario
        char resp;
        string[] opciones =
        {
            "Insertar",
            "Imprimir"
        };

        do
        {
            Console.Clear();
            Console.WriteLine("ARBOLES BINARIOS DE BUSQUEDA");
            for (var i = 0; i < opciones.Length; i++) Console.WriteLine($"{i + 1}.- {opciones[i]}");
            resp = Console.ReadKey(false).KeyChar;
            Console.Clear();
            switch (resp)
            {
                case '1':
                    Console.WriteLine("Escribe un número entero");
                    tree.Insert(int.Parse(Console.ReadLine() ?? string.Empty));
                    break;
                case '2':
                    tree.PrintNode(tree.Root);
                    Console.WriteLine("Presiona un botón para continuar...");
                    Console.ReadLine();
                    break;
                case '9':
                    Console.WriteLine("Hasta luego!");
                    break;
            }
        } while (resp != '9');
    }
}