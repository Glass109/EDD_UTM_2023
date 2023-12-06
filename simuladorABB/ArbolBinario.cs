
using System.Text;

namespace simuladorABB
{
    class ArbolBinario
    {
        NodoArbol root;
        List<NodoArbol> misNodos = new List<NodoArbol>();

        public ArbolBinario()
        {
            root = new NodoArbol(8);
        }

        public bool Vacio()
        {
            return root == null;
        }

        public void Insertar(Object el)
        {
            this.Insertar(root, el);
            PreOrden();
        }

        private void Insertar(NodoArbol actual, Object el)
        {
            if (root == null)
                root = new NodoArbol(el);
            else
            {
                if ((int)actual.info >= (int)el)
                {
                    if (actual.Left != null)
                        Insertar(actual.Left, el);
                    else
                        actual.Left = new NodoArbol(el);
                }
                else
                {
                    if (actual.Right != null)
                        Insertar(actual.Right, el);
                    else
                        actual.Right = new NodoArbol(el);
                }
            }
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
                PreOrden(root.Left);
            }
            if (root.Right != null)
            {
                PreOrden(root.Right);
            }
        }

        public void MostrarPre()
        {
            foreach (var item in misNodos)
            {
                Console.Write(item.info + ", ");
            }
        }

        public NodoArbol? Buscar(int valor)
        {
            foreach (var item in misNodos)
            {
                if ((int)item.info == valor)
                {
                    return item;
                }
            }
            return null;
        }

        public void Eliminar(int valor)
        {
            root = Eliminar(root, valor);
            if (!Vacio())
            {
                PreOrden();
            }
        }

        private NodoArbol Eliminar(NodoArbol actual, int valor)
        {
            if (actual == null)
            {
                return actual!;
            }
            if (valor < (int)actual.info)
            {
                actual.Left = Eliminar(actual.Left, valor);
            }
            else if (valor > (int)actual.info)
            {
                actual.Right = Eliminar(actual.Right, valor);
            }
            else
            {
                if (actual.Left == null)
                {
                    return actual.Right;
                }
                else if (actual.Right == null)
                {
                    return actual.Left;
                }
                actual.info = MinValor(actual.Right);
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

        public int Altura()
        {
            return Altura(root);
        }

        private int Altura(NodoArbol root)
        {
            if (root == null) return 0;
            else
            {
                int alturaIzq = Altura(root.Left);
                int alturaDer = Altura(root.Right);
                Console.WriteLine(Math.Max(alturaIzq, alturaDer) + 1);
                return Math.Max(alturaIzq, alturaDer) + 1;
            }
        }

        public int[,] aMatriz()
        {
            int altura = Altura();
            int ancho = (int)(2 * (Math.Pow(2, altura - 1)) - 1);
            int[,] matriz = new int[altura, ancho];
            int mitad = (int)(ancho / 2);
            matriz[0, mitad] = (int)root.info;
            Anchura(root, matriz, 0, mitad);
            for (int i = 0; i < altura; i++)
            {
                for (int j = 0; j < ancho; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
            return matriz;
        }

        private void Anchura(NodoArbol root, int[,] matriz, int nivel, int posicion)
        {
            if (root == null)
                return;

            int altura = matriz.GetLength(0);

            if (root.Left != null)
            {
                int nuevaPosicion = (int)(posicion - Math.Pow(2, altura - nivel - 2));
                matriz[nivel + 1, nuevaPosicion] = (int)root.Left.info;
                Anchura(root.Left, matriz, nivel + 1, nuevaPosicion);
            }

            if (root.Right != null)
            {
                int nuevaPosicion = (int)(posicion + Math.Pow(2, altura - nivel - 2));
                matriz[nivel + 1, nuevaPosicion] = (int)root.Right.info;
                Anchura(root.Right, matriz, nivel + 1, nuevaPosicion);
            }
        }
        public string RecorridoPreOrder()
        {
            StringBuilder result = new StringBuilder();
            PreOrderTraversal(root, result);
            return result.ToString();
        }
        private void PreOrderTraversal(NodoArbol node, StringBuilder result)
        {
            if (node == null)
                return;

            result.Append(node.info.ToString() + " ");
            PreOrderTraversal(node.Left, result);
            PreOrderTraversal(node.Right, result);
        }

        public string RecorridoInOrder()
        {
            StringBuilder result = new StringBuilder();
            InOrderTraversal(root, result);
            return result.ToString();
        }

        private void InOrderTraversal(NodoArbol node, StringBuilder result)
        {
            if (node == null)
                return;

            InOrderTraversal(node.Left, result);
            result.Append(node.info.ToString() + " ");
            InOrderTraversal(node.Right, result);
        }

        public string RecorridoPostOrder()
        {
            StringBuilder result = new StringBuilder();
            PostOrderTraversal(root, result);
            return result.ToString();
        }

        private void PostOrderTraversal(NodoArbol node, StringBuilder result)
        {
            if (node == null)
                return;

            PostOrderTraversal(node.Left, result);
            PostOrderTraversal(node.Right, result);
            result.Append(node.info.ToString() + " ");
        }

        public string RecorridoPorAnchura()
        {
            StringBuilder result = new StringBuilder();
            Queue<NodoArbol> queue = new Queue<NodoArbol>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                NodoArbol node = queue.Dequeue();
                result.Append(node.info.ToString() + " ");

                if (node.Left != null)
                    queue.Enqueue(node.Left);

                if (node.Right != null)
                    queue.Enqueue(node.Right);
            }

            return result.ToString();


        }
    }
}