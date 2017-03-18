using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList
{
    class LinkedList
    {
        LinkedListNode head;

        public void Add(int valor)
        {
            head = new LinkedListNode(valor, head);
            //Console.WriteLine($"LinkedList.Add({valor});");
            //Console.WriteLine();
            //Console.WriteLine(ToString());
            //Console.WriteLine();
        }

        public void Clear()
        {
            head = null;
        }

        public bool Contains(int valor)
        {
            
            var iterador = head;

            while (iterador != null)
            {
                if (iterador.Valor == valor)
                {
                    return true;
                }
                iterador = iterador.Next;
            }
            return false;
        }

        public bool remove(int valor)
        {
            var iterador = head;
            LinkedListNode anterior = null;

            if (head.Valor == valor)
            {
                head = head.Next;
                return true;
            }

            while (iterador != null)
            {
                if (iterador.Valor == valor)
                {
                    anterior.Next = iterador.Next;
                    return true;
                }
                anterior = iterador;
                iterador = iterador.Next;
            }
            return false;
        }

        //public override string ToString()
        //{
        //    StringBuilder sb = new StringBuilder();

        //    var iterador = head;
        //    while (iterador != null)
        //    {
        //        sb.Append(iterador.Valor + " > ");
        //        iterador = iterador.Next;
        //    }

        //    sb.Append("null");

        //    return sb.ToString();
        //}

        public override string ToString()
        {
            string retorno = "";
            LinkedListNode iterador = head;
            while (iterador != null)
            {
                retorno += iterador.Valor + " > " ;
                iterador = iterador.Next;
            }
            retorno += "null";

            return retorno;
        }
    }
}
