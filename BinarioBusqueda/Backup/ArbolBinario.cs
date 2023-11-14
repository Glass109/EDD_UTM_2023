using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinarioBusqueda
{
    class ArbolBinario
    {
        NodoArbol root;

        public ArbolBinario()
        {
            root = null;        
        }

        public void Inserta(Object el)
        {
            this.Inserta(root, el);
        }

       
        private void Inserta(NodoArbol actual, Object el)
        {
            if (root == null)
                root = new NodoArbol(el);
            else
            {
                if ((int)actual.info >= (int)el)
                    if (actual.Left != null)
                        Inserta(actual.Left, el);
                    else
                        actual.Left = new NodoArbol(el);
                else
                    if (actual.Right != null)
                        Inserta(actual.Right, el);
                    else
                        actual.Right = new NodoArbol(el); 
            }                    
        }
    }
}
