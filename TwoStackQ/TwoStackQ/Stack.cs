using System;
using System.Collections.Generic;
using System.Text;

namespace TwoStackQ
{
    class Stack
    {
       public Node Head;

        public void Push(object data)
        {
            Node newNode = new Node(data);
            newNode.Next = Head;
            Head = newNode;
        }

        public void Pop()
        {
            Head = Head.Next;
        }

        public object Pop(bool value)
        {
            Node curr = Head;
            Head = Head.Next;
            return curr.Data;
        }
        public void PrintState()
        {
            while (Head.Next != null)
            {
                Console.Write("->");
                Console.Write(Head.Data);
            }
            Head = Head.Next;
        }

        public void PrintSingle()
        {
            Console.Write("->");
            Console.Write(Head.Data);
        }
    }
}
