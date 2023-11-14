using System;
using System. Collections. Generic ;
using System. Linq;
using System. Text;
namespace ColaDobleLigadas
{
    public class NodoColas
    {
        public NodoColas prev = null, next;
        public object info;
        public NodoColas(object el, NodoColas sig)
        {
            info = el;
            next = sig;
        }
    }

}
