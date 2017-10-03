using System;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tree\n");

            Tree myTree = new Tree("root");

            myTree.Add();


            myTree.Print();
            Console.Read();
        }
    }
}
