using System;
using System.Collections.Generic;
using System.Text;

namespace doubly_linked_list
{
    class doubly
    {
        public Node head;
        public Node curr;

        public doubly(int data)
        {
            head = new Node(data);                      
            curr = head;
        }

        public void Add(object data)
        {
            Node newnode = new Node(data);
            curr.Next = newnode;
            newnode.Prev = curr;
            curr = newnode;
        }
        public void Print()
        {
            curr = head;
            while(curr.Next != null)
            {   
                Console.Write("->");
                Console.Write(curr.Data);
                curr = curr.Next;
                

            }
            Console.Write("->");
            Console.Write(curr.Data);
            Console.Write("->");
            Console.Write("null");
        }
        public void Remove(object data)
        {
            curr = head;
            while (curr.Next != null)
            {
                if (curr.Data.ToString() == data.ToString())
                {
                    curr.Next = null;
                    curr.Next.Prev = curr;
                    curr.Next = curr.Next.Next;
                }
            curr = curr.Next;
            }
            //Console.WriteLine(curr.Next.Data);
        }

    }
}
