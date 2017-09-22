using System;
using System.Collections.Generic;
using System.Text;

namespace linkedlist_remove
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
        public void FindNth(int nth)
        {
            Console.Write("Head ->");
            Node curr = head;
            Node curr2 = head;
            int innerCount = 0;

            while (curr.Next != null)
            {
                curr = curr.Next;
                innerCount++;
            }
            for(int i = 0; i < count - nth; i++)
            {
                curr2 = curr2.Next;
                Console.Write(curr2.Data);
                Console.Write("->");
            }
            Console.Write("End");
        }
        public void Remove(int input)
        {
            int index = input - 1;
            Console.Write("Head ->");
            Node curr = head;
            Node curr2 = head;
            int innerCount = 0;

            while (curr.Next != null)
            {
                curr = curr.Next;
                innerCount++;
            }
            for (int i = 0; i < count - index; i++)
            {
                curr2 = curr2.Next;
                Console.Write(curr2.Data);
                Console.Write("->");

            }
            curr2 = curr2.Next.Next;
            for (int i = 0; i < index; i++)
            {
                curr2 = curr2.Next;
                Console.Write(curr2.Data);
                Console.Write("->");
            }
                Console.Write("End");
        }

    }
}
