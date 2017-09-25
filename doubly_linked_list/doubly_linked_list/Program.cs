using System;

namespace doubly_linked_list
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            doubly doubly = new doubly(1);

            doubly.Add(2);
            doubly.Add(3);
            doubly.Add(4);
            doubly.Add(5);
            doubly.Remove(3);
            doubly.Print();

            Console.Read();
        }
    }
}
