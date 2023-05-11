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
            Console.WriteLine("Welcome to LinkedList problem");

            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AddLast(50);
            linkedList.AddLast(30);
            linkedList.AddFirst(70);
            foreach (int element in linkedList)
            {
                Console.Write(element+" ");
            }
            Console.ReadLine();
        }
    }
}
