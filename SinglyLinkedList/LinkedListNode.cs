using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList
{
    class LinkedListNode
    {
        private int valor;
        private LinkedListNode next;

        public int Valor
        {
            get { return valor; }
            
        }

        internal LinkedListNode Next
        {
            get { return next; }

            set { next = value; }
        }

        public LinkedListNode (int valor, LinkedListNode next)
        {
            this.valor = valor;
            this.Next = next;
        }
        
    }
}
