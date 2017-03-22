using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new LinkedList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            Console.WriteLine(list.ToString());
            //Console.WriteLine(list.Contains(4));
            //Console.ReadKey();
            //Console.WriteLine(list.remove(2));
            //Console.WriteLine(list.Contains(2));
            Console.ReadKey();

            foreach (var item in list)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadKey();
        }
    }
}
