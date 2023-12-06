//using System.Linq;
namespace simuladorABB;

class NodoArbol
{
    public Object info;
    public NodoArbol Left, Right;
    public NodoArbol(Object el) : this(el, null, null) { }

    public NodoArbol(Object el, NodoArbol left, NodoArbol right)
    {
        info = el;
        Left = left;
        Right = right;
    }
}
