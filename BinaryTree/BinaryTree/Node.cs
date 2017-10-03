using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    class Node
    {
        public string Data { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node(string data)
        {
            Data = data;
            Left = null;
            Right = null;
        }

    }
}
