using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    class Tree
    {
        public Node Root { get; set; }

        public Tree(string data)
        {
            Root = new Node(data);
        }

        public void Add()
        {
            Root.Left = new Node("one");
            Root.Right = new Node("two");
            Root.Left.Left = new Node("three");
            Root.Left.Right = new Node("four");
            Root.Right.Left = new Node("five");
            Root.Right.Right = new Node("six");
        }

        public void Print()
        {
            
            Console.Write($" {Root.Data}\n {Root.Left.Data} {Root.Right.Data}\n {Root.Left.Left.Data} {Root.Left.Right.Data} {Root.Right.Left.Data} {Root.Right.Right.Data} ");
        }

    }
}
