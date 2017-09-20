using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_lists_find
{
    class LinkedList
    {
        public Node head;
        public Node curr;
        public int count = 0;
        public int midCount;
        
        public LinkedList(int data)
        {
            head = new Node(data);
            curr = head;
        }

        public void Add(int data)
        {
            Node newNode = new Node(data);
            newNode.Data = data;
            curr.Next = newNode;
            curr = newNode;
            count++;
            if (count % 2 == 1)
            {
                midCount++;
            }

        }
        public void PrintAllNodes()
        {
            Console.Write("Head ->");
            Node curr = head;

            while (curr.Next != null)
            {
                curr = curr.Next;
                Console.Write(curr.Data);
                Console.Write("->");
            }
            Console.Write("This is the end");
        }
        public void Printmid()
        {
            Console.Write("Head ->");
            Node curr = head;
            int start = 0;

            while (start < midCount)
            {
                curr = curr.Next;
                Console.Write(curr.Data);
                Console.Write("->");
                start++;
            }
            Console.Write("This is the end");

        }
    }
}
