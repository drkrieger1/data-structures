using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data structure practice");

            LinkedList myList = new LinkedList();

            myList.AddLast(1);
            myList.AddLast(2);
            myList.AddLast(3);
            myList.AddLast(4);
            myList.Remove(3);

            myList.Print();

            Console.WriteLine();

            //LinkedList frontList = new LinkedList();

            //frontList.AddFirst(1);
            //frontList.AddFirst(2);
            //frontList.AddFirst(3);
            //frontList.AddFirst(4);

            //frontList.Print();

            Console.Read();
        }
    }
}
