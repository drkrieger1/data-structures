using System;
using System.Collections.Generic;
using System.Text;

namespace Palindrome
{
    class Doubly_list
    {
        Node Head;
        Node Tail;

        public Doubly_list()
        {
            Head = new Node("Head");
            Tail = new Node("Tail");
            Head.Next = Tail;
            Tail.Prev = Head;
        }

        public void Add(object data)
        {
            Node newNode = new Node(data);
            newNode.Prev = Tail;

            newNode.Prev = Tail.Prev;
            Tail.Prev.Next = newNode;
            Tail.Prev = newNode;
            newNode.Next = Tail;

            //curr.Next = newNode;
            //newNode.Next = Tail;
            //newNode.Prev = curr;
            //Tail.Prev = newNode;
            //curr = newNode; 
        }
       
        public string Check()
        {
            Node Forward = Head;
            Node Back = Tail;
            string answer = "false";
            while(Forward.Next.Data.ToString() == Back.Prev.Data.ToString())
            {
                if (Forward.Next.Data.ToString() != Back.Prev.Data.ToString())
                {
                    answer = "false";
                    break;
                }
                if(Forward.Next == Back.Prev && Forward.Next.Data.ToString() == Back.Prev.Data.ToString())
                {
                    answer = "true";
                    break;
                }
                Forward = Forward.Next;
                Back = Back.Prev;
            }
            return answer; 
        }

        public void Converter(string thing)
        {
            char[] thing2 = thing.ToCharArray();
            foreach (char n in thing2)
            {
                this.Add(n);
            }
            
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
            Console.Write("-> Tail");
        }
    }
}
