using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{   
    class Node
    {
        public Node Next { get; set; }
        public int Data { get; set; }

        public Node(int data)
        {
            Next = null;
            Data = data;
        }
    }
    class LinkedList
    {
        public Node head;
        public Node tail;

        public LinkedList()
        {
            Node head = new Node(0);
            Node tail = head;
        }

        internal Node Tail { get => tail; set => tail = value; }

        //This method will add to the linked list
        public void AddLast(int data)
        {
            if(tail.Next == null)
            {
                tail.Next = new Node(data);
                tail = tail.Next;
            }

            Tail = Tail.Next;
            AddLast(data);          
        }

        public void Print()
        {
            Console.Write($"Head ->");
            head = head.Next;
            while(head.Next != null)
            {
                Console.Write($"{head.Data} ->");
            }

            Console.Write("Tail");
        }
    }
}
