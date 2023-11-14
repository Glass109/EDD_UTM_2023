using System;

namespace BinarioBusqueda;

internal class BinaryTree
{
    public TreeNode Root;

    public void Insert(object obj)
    {
        if (Root == null)
            Root = new TreeNode(obj);
        else
            Insert(Root, obj);
    }

    private void Insert(TreeNode actual, object obj)
    {
        if ((int)actual.Data >= (int)obj)
            if (actual.Left != null)
                Insert(actual.Left, obj);
            else
                actual.Left = new TreeNode(obj);
        else if (actual.Right != null)
            Insert(actual.Right, obj);
        else
            actual.Right = new TreeNode(obj);
    }

    public void PrintNode(TreeNode node = null, int level = 0)
    {
        if (node == null) return; //Si el nucleo del arbol no existe, termina la función
        if (node.Right != null)
            PrintNode(node.Right, level + 1);
        Console.WriteLine($"{new string('>', level)} {node.Data}");
        if (node.Left != null)
            PrintNode(node.Left, level + 1);
        ;
    }
}