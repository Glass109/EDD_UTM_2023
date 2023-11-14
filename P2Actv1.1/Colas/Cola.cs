using System;
using System. Collections. Generic ;
using System. Linq;
using System. Text;
namespace ColaDobleLigadas
{
    public class Cola
    {
        public NodoColas head,tail;
        public Cola()
        {
            head = tail = null;
        }
    }
    
    public void vaciarCola()
    {
        head = tail = null;
    }

    public void Enqueue(object el)
    {
        if (tail == null)
        {
            tail = head = new NodoColas(el, head);
        } 
        else
        {
            head.prev = new NodoColas(el,head);
            head = head.prev;
        }
    }

    public Object Dequeue()
    {
        if (tail == null) return "Cola Vacía";
        else
        {
            object temp = null;
            if (head == tail)
            {
                temp = head.info;
                head = tail = null;
            }
            else
            {
                temp = tail.info;
                tail = tail.prev;
                tail.next = null;
            }
            return temp;
        } 
    }

    public bool Vacio()
    {
        return tail == null;
    }

}
