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
            head = new Node(0);
            tail = head;
        }


        //This method will add to the linked list
        public void AddLast(int data)
        {        
            tail.Next = new Node(data);
            tail = tail.Next;        
        }

        public void Print()
        {
            Node curr = head;
            Console.Write($"Head ->");
            curr = curr.Next;

            while(curr.Next != null)
            {
                Console.Write($"{curr.Data} ->");
                curr = curr.Next;
            }
            Console.Write($"{curr.Data} ->");
            Console.Write("Tail");
        }

        public void AddFirst(int data)
        {
            Node newNode = new Node(data);

            newNode.Next = head.Next;
            head.Next = newNode;
        }

        public void Remove(int data)
        {
            //find the node that will be removed

        }
    }
}
