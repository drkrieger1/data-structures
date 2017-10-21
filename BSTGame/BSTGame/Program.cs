using System;

namespace BSTGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BST Game");
            GameLoad();
            Console.Read();

        }
        static void GameLoad()
        {
            Tree myTree = new Tree();
            myTree.Add(myTree.root,5,"Is it a mammal?");
            myTree.Add(myTree.root, 3, "Does it bark");
            myTree.Add(myTree.root, 2, "Is it a Dog?");
            myTree.Add(myTree.root, 4, "Is it a what is it?");
            myTree.Add(myTree.root, 7, "Can it fly?");
            myTree.Add(myTree.root, 6, "Is it a bird?");
            myTree.Add(myTree.root, 8, "what is it?");
        }
    }
    class Tree
    {
        public Node root;

        public Tree()
        {
            root = null; 
        }

        public Node Add(Node root, int data, string quest)
        {
            if(root == null)
            {
               return root = new Node(data, quest);
            }

            if(data < root.Data)
            {
                root.Left = Add(root.Left, data, quest);
            }else if(data > root.Data)
            {
                root.Right = Add(root.Right, data, quest);
            }
            return root;
        }
        public string Move(string input)
        {
            Node curr = root;

            if(input == "yes"|| input == "y")
            {
               curr = root.Left;
               return curr.Question;
            }else if(input == "no"|| input == "n")
            {
                curr = root.Right;
                return curr.Question;
            }
            return curr.Question;
        }
    }
    class Node
    {
        public int Data { get; set; }
        public string Question { get; set; }
        public Node Right { get; set; }
        public Node Left { get; set; }

        public Node(int data, string quest)
        {
            Data = Data;
            Question = quest;
            Right = null;
            Left = null;
        }
    }


}
