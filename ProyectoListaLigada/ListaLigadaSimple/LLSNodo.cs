using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaLigadaSimple
{
    public class LLSNodo
    {
        public int info;
        public LLSNodo next;
        public LLSNodo(int el) : this(el, null) { }
        public LLSNodo(int el, LLSNodo sig) 
        {
            info = el;
            next = sig;
        }
    }
}
