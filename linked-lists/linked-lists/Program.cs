using System;
using linked_lists;

namespace linked_lists
{
 
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList lnklist = new LinkedList();
            lnklist.PrintAllNodes();
            Console.WriteLine();

            lnklist.AddAtLast("node1");
            lnklist.AddAtLast("node2");
            lnklist.AddAtLast("node3");
            lnklist.AddAtLast("node4");
            lnklist.PrintAllNodes();
            Console.WriteLine();

            Console.Read();
        }
    }
}
