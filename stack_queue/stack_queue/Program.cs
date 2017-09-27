using System;

namespace stack_queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Queue:Stack");

            Queue myQueue = new Queue();
            Console.WriteLine("The Queue");
            myQueue.AddQueue(1);
            myQueue.AddQueue(2);
            myQueue.AddQueue(3);
            myQueue.AddQueue(4);
            myQueue.AddQueue(5);
            myQueue.Print();

            Console.WriteLine("\n\nThe DeQueue");
            myQueue.DeQueue();
            myQueue.Print();


            Console.WriteLine("\n\n The Stack");

            Stack myStack = new Stack();

            myStack.Add(1);
            myStack.Add(2);
            myStack.Add(3);
            myStack.Add(4);
            myStack.Add(5);
            myStack.Print();

            Console.WriteLine("\n\nStack POP!");
            myStack.Pop();
            myStack.Print();


            Console.Read();

        }
    }
}
