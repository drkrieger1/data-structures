using System;

namespace InorderTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data tree traversal");

            Tree mytree = new Tree(1);

            mytree.Left = new Tree(2);
            mytree.Left.Left = new Tree(3);
            mytree.Left.Right = new Tree(4);
            mytree.Right = new Tree(5);
            mytree.Right.Left = new Tree(6);
            mytree.Right.Right = new Tree(7);

            mytree.Travers();

            Console.Read();
        }
    }
}
