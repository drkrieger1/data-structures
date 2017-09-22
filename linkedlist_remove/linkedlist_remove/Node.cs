using System;
using System.Collections.Generic;
using System.Text;

namespace linkedlist_remove
{
    class Node
    {
        public Node Next { get; set; }
        public int Data { get; set; }

        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }
}
