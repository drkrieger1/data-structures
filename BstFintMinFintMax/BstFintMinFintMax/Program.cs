using System;

namespace BstFintMinFintMax
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Search Tree \b");

            SearchTree testTree = new SearchTree();
            testTree.Add(testTree.Root, 5);
            testTree.Add(testTree.Root, 6);
            testTree.Add(testTree.Root, 4);
            testTree.Add(testTree.Root, 1);

            testTree.Max(testTree.Root);
            testTree.Min(testTree.Root);
            Console.Read();
        }
    }
    public class SearchTree
    {
        public Node Root { get; set; }
        public void Add(Node node, int data)
        {
            if (Root == null)
            {
                Root = new Node(data);
                Console.WriteLine(Root.Data);
                return;
            }
            if (node.Data == data)
            {
                return;
            }
            if (data < node.Data)
            {
                if (node.Left == null)
                {
                    node.Left = new Node(data);
                    Console.WriteLine(node.Left.Data);
                    return;
                }
                Add(node.Left, data);
            }
            if (data > node.Data)
            {
                if (node.Right == null)
                {
                    node.Right = new Node(data);
                    Console.WriteLine(node.Right.Data);
                    return;
                }
                Add(node.Right, data);
            }
        }

        public class Node
        {
            public int Data { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }
            public Node(int data)
            {
                Data = data;
                Left = null;
                Right = null;
            }
        }

        public void Min(Node node)
        {
            Node current = node;
            if (current.Left == null)
            {
                Console.WriteLine($"{current.Data} is the min");
            }
            while (current.Left != null)
            {
                current = current.Left;
                if (current.Left == null)
                {
                    Console.WriteLine($"{current.Data} is the min");
                }
            }
        }
        public void Max(Node node)
        {
            Node current = node;
            if (current.Right == null)
            {
                Console.WriteLine($"{current.Data} is the max");
            }
            while (current.Right != null)
            {
                current = current.Right;
                if (current.Right == null)
                {
                    Console.WriteLine($"{current.Data} is the max");
                }
            }
        }
    }


}
