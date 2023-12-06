namespace BinarioBusqueda
{
    class ArbolBinario
    {
        NodoArbol root;
        List<NodoArbol> misNodos = new List<NodoArbol>();

        public ArbolBinario()
        {
            root = null;
            root = new NodoArbol(8);
            root.Left = new NodoArbol(3);
            root.Right = new NodoArbol(10);
        }
        public bool Vacio()
        {
            return root == null;
        }
        public void Insertar(Object el)
        {
            this.Insertar(root, el);
        }
        private void Insertar(NodoArbol actual, Object el)
        {
            if (root == null)
                root = new NodoArbol(el);
            else
            {
                if ((int)actual.info >= (int)el)
                    if (actual.Left != null)
                        Insertar(actual.Left, el);
                    else
                        actual.Left = new NodoArbol(el);
                else
                    if (actual.Right != null)
                    Insertar(actual.Right, el);
                else
                    actual.Right = new NodoArbol(el);
            }
            PreOrden();
        }
        public void PreOrden()
        {
            misNodos.Clear();
            this.PreOrden(root);
        }
        public void PreOrden(NodoArbol root)
        {
            misNodos.Add(root);
            if (root.Left != null)
            {
                PreOrden(root.Left);//aca mi brazo der
            }
            if (root.Right != null)
            {
                PreOrden(root.Right);//aca mi brzo izq
            }
        }
        public void MostrarPre()
        {
            foreach (var item in misNodos)
            {
                Console.Write(item.info + ", ");
            }
        }
        public bool Buscar(int valor)
        {
            foreach (var item in misNodos)
            {
                if ((int)item.info == valor)
                {
                    return true;
                }
            }
            return false;
        }

        public void Eliminar(int valor)
        {
            root = Eliminar(root, valor);
            if (!Vacio())
            {
                PreOrden();
            }
            //PreOrden();
        }
        private NodoArbol Eliminar(NodoArbol actual, int valor)
        {
            if (actual == null)
            {
                return actual;
            }
            if (valor < (int)actual.info)
            {
                actual.Left = Eliminar(actual.Left, valor);
            }
            else if (valor > (int)actual.info)
            {
                actual.Right = Eliminar(actual.Right, valor);
            }
            else//si el numero no es mayor ni menor, entonces es el numero q busco
            {
                if (actual.Left == null)//si es null, significa que no tengo 2 nodos
                {
                    return actual.Right;//si en este paso regreso un null tambien, significa que s etrata de una hoja
                }
                else if (actual.Right == null)//se aplica lo mismo que lo de arriba
                {
                    return actual.Left;//se aplica lo mismo que lo de arriba
                }
                actual.info = MinValor(actual.Right);//para cuando si tengo 2 nodos

                actual.Right = Eliminar(actual.Right, (int)actual.info);
            }
            return actual;
        }

        private int MinValor(NodoArbol nodo)
        {
            int minValue = (int)nodo.info;
            while (nodo.Left != null)
            {
                minValue = (int)nodo.Left.info;
                nodo = nodo.Left;
            }
            return minValue;
        }
        public void Graficar()
        {
            int left = Console.CursorLeft;
            int top = Console.CursorTop;
            Console.SetCursorPosition(left + 70, top);
            Console.Write(root.info);
            this.PreOrden(root);
        }
        public void Graficar(NodoArbol root)
        {
            misNodos.Add(root);
            if (root.Left != null)
            {

                PreOrden(root.Left);//aca mi brazo der
            }
            if (root.Right != null)
            {
                PreOrden(root.Right);//aca mi brzo izq
            }
        }

        // public void PreOrden(NodoArbol root, int valor)
        // {
        //     if ((int)root.info == valor)
        //     {
        //         Console.WriteLine("Encontrado: " + valor);
        //         return;
        //     }
        //     else
        //     {
        //         if (root.Left != null)
        //         {
        //             PreOrden(root.Left, valor);//aca mi brazo der
        //         }
        //         if (root.Right != null)
        //         {
        //             PreOrden(root.Right, valor);//aca mi brzo izq
        //         }
        //     }
        // }
    }
}