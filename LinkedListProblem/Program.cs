using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomLinkedList customLinkedList = new CustomLinkedList();
            customLinkedList.AddFirst(70);
            customLinkedList.AddFirst(30);
            customLinkedList.AddFirst(56);
            customLinkedList.Display();
            Console.ReadLine();
        }
    }
}
