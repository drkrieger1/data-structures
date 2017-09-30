using System;
using System.Collections.Generic;
using System.Text;

namespace OrderedStack
{
    class Stack
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }

        public Stack(int data)
        {
            Head = new Node(data);
            Tail = Head;
        }

        public Node Sort(int data)
        {
            Node curr = Head;

            while(data < curr.Data)
            {
                if(curr.Next == null)
                {
                    return null;
                }
                curr = curr.Next;
            }
            return curr.Next;
        }
        public void Push(int data)
        {
            Node curr = Head;
            Node newNode = Sort(data);

            newNode.Prev = curr.Prev;
            newNode.Next = curr;
            curr.Prev.Next = newNode;
            curr.Prev = newNode;
        }
        public void Print()
        {
            Node curr = Head;
            while(curr.Next != null)
            {
                Console.Write("->");
                Console.Write(curr.Data);
                curr = curr.Next;
            }
            Console.Write(curr.Data);
            Console.Write("Tail");
        }
        
    }
}
