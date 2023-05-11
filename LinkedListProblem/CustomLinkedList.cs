using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblem
{
    public class CustomLinkedList
    {
        public Node head;
        public void AddFirst(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                Console.WriteLine("{0} node is added into linkelist", newNode.data);
            }
            else
            {
                newNode.next = head;
                head = newNode;
                Console.WriteLine("{0} node is added into linkelist", newNode.data);
            }
        }
        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("LinkedList is empty");
            }
            else
            {
                Node temp = head;
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;

                }
            }
        }
    }
}
