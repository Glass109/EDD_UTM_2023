using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaLigadaSimple
{
    public class LSS{
        protected LLSNodo inicio, final;
        public LSS() { inicio = final = null; }
        public bool estaVacia() { return inicio == null; }
        
        public void insertarInicio(int el) 
        {
            inicio = new LLSNodo(el, inicio);
            if (final == null) 
            {
                final = inicio;
            }
        }
        public void insertarFinal(int el)
        {
            if (inicio == null) //si la lista esta vacía se utiliza insertarInicio
                insertarInicio(el);
            else  //si la lista no esta vacía, debemos posicionar un elemento en el último nodo
            {
                LLSNodo temp; //Nombre del nodo temporal que se posiciona en la última posición
                for (temp = inicio; temp.next != null; temp=temp.next) ; //Posiciona a temp en la última posición
                temp.next = new LLSNodo(el);
            }
        }
        public bool eliminarInicio() 
        {
            if (inicio == null) //si la lista esta vacía no es posible eliminar
                return false;
            else
                inicio = inicio.next;
            return true;
        }
        public bool eliminarFinal()
        {
            if (inicio == null) //si la lista esta vacía no es posible eliminar
                return false;
            if (inicio.next == null) //si la lista solo tiene un nodo utilizamos eliminarInicio
                return eliminarInicio();
            LLSNodo temp=encontrarPenultimo(); //Utiliza un método auxiliar para encontrar el penúltimo
            temp.next=null;
            return true;
        }
        public void mostrarLista() 
        {
            for (LLSNodo temp = inicio; temp != null; temp=temp.next)
                System.Console.Write(temp.info + "->");
        }
        public int numeroElementos() 
        {
            int elementos = 0;
            for (LLSNodo temp = inicio; temp != null; temp = temp.next, elementos++) ;
            return elementos;
        }
        public LLSNodo encontrarPenultimo() //método que sirve para devolver el penúltimo elemento de la lista
        {
            LLSNodo temp = inicio, ultimo;
            for (ultimo = inicio; ultimo.next != null; ultimo = ultimo.next)
                temp = ultimo;
            return temp;
        }
        public bool buscarElemento(int el)
        {
            LLSNodo temp= inicio;
            while (temp != null) //mientras no llegue al final
            {
                if(temp.info == el) //Si lo encuentra devuelve true
                    return true;
                temp = temp.next;
            }
            return false; //No lo encontro, devuelve false
        }
        public void borrarElemento(int el)
        { 
        }
        public void Burbuja() 
        {
            if(numeroElementos() > 1) //Si la lista tiene mas de un elemento
            {
                LLSNodo primero, segundo;
                bool seguir = true;
                while (seguir) 
                {
                    seguir = false;
                    for (primero = inicio, segundo = inicio.next; segundo != null; primero = primero.next, segundo = segundo.next) 
                        if (primero.info > segundo.info) 
                        {
                            int intTemp = primero.info;
                            primero.info = segundo.info;
                            segundo.info=intTemp;
                            seguir=true;
                        }
                }
            }
        }
        public void Invertir() 
        {
            if (numeroElementos() >1) //Si la lista tiene mas de un elemento
            {
                LLSNodo frente = inicio, atras;
                for (atras = inicio; atras.next != null; atras = atras.next) ; //Coloca atras en la última posición
                while (frente != atras && atras.next != frente) 
                {
                    int temp = frente.info;
                    frente.info = atras.info;
                    atras.info = temp;
                    frente = frente.next;
                    LLSNodo nodoTemp = atras;
                    for (atras = inicio; atras.next != nodoTemp; atras = atras.next) ;
                }
            }
        }
        public void InsertarEnIndice(int idx, int valor){
            if(estaVacia()){
                throw new Exception("ListaVacia");
                //TOOD
            }
        }
        public int ContarNumNodos(){
            int i = 0;
            while(inicio.next != null){
                i++;
                inicio = inicio.next;
            }
            return i;
        }
    }
}
