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

            Console.WriteLine("\n\nThe Queue");
            myQueue.DeQueue();
            myQueue.Print();

            Console.Read();

        }
    }
}
