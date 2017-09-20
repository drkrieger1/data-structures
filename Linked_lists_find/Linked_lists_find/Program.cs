using System;

namespace Linked_lists_find
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            LinkedList newList = new LinkedList(1);

            newList.Add(24);
            newList.Add(13);
            newList.Add(15);

            newList.Printmid();

            
            Console.Read();
            

        }
    }
}
