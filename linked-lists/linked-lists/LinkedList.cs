using System;
using System.Collections.Generic;
using System.Text;

namespace linked_lists 
{
    class LinkedList
    {
        private Node head;
        private Node current;
        public int Counter;

        public LinkedList()
        {
            head = new Node();
            current = head;
        }

        public void AddAtLast(Object data)
        {
            Node newNode = new Node();
            newNode.Value = data;
            current.Next = newNode;
            current = newNode;
            Counter++;
        }

        public void AddAtstart(object data)
        {
            Node newNode = new Node() { Value = data };
            newNode.Next = head.Next;
            head.Next = newNode;
            Counter++;
        }

        public void PrintAllNodes()
        {
            Console.WriteLine("Head ->");
            Node curr = head;
            while (curr.Next != null)
            {
                curr = curr.Next;
                Console.WriteLine(curr.Value);
                Console.WriteLine("->");
            }
            Console.WriteLine("is null");
        }
    
    }
}
