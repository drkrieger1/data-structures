using System;
using System.Collections.Generic;
using System.Text;

namespace TraversTree
{
    class Tree
    {
        public int Data { get; set; }
        public Tree Left { get; set; }
        public Tree Right { get; set; }

        public Tree(int data)
        {
            Data = data;
            Left = null;
            Right = null;
        }

        public void Travers()
        {
            if(Right != null)
            {
                Right.Travers();
            }
            if(Left != null)
            {
                Left.Travers();
            }
            Console.Write(Data);
        }
    }
}
