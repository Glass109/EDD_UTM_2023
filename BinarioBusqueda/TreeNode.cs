namespace BinarioBusqueda;

internal class TreeNode
{
    public object Data;
    public TreeNode Left, Right;

    public TreeNode(object obj, TreeNode left = null, TreeNode right = null)
    {
        Data = obj;
        Left = left;
        Right = right;
    }
}