using System;

namespace TwoStackQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Two stack Q");

            TwoStackQ myQueue = new TwoStackQ();

            myQueue.Queue(1);
            myQueue.Queue(2);
            myQueue.Queue(3);
            myQueue.Queue(4);

            myQueue.DeQueue();
            Console.Read();

        }
    }
}
