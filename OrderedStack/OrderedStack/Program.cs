using System;

namespace OrderedStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ordered stack \n");
            Stack myStack = new Stack(0);

            myStack.Push(3);
            myStack.Push(5);
            myStack.Push(1);
            myStack.Push(4);
            myStack.Push(2);

            myStack.Print();
            Console.Read();
        }
    }
}
