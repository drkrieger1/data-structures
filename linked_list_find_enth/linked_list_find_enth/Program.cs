using System;

namespace linked_list_find_enth
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

            linked.FindNth(3);
            Console.Read();
        }
    }
}
