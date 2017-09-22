using System;

namespace linkedlist_remove
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find nth");

            LinkedList linked = new LinkedList(1);

            linked.Add(2);
            linked.Add(3);
            linked.Add(4);
            linked.Add(5);
            linked.Add(6);

            linked.Remove(3);
            Console.Read();
        }
    }
}
