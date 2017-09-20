using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_lists_find
{
    class Node
    {
        public Node Next { get; set; }
        public Object Data { get; set; }

        public Node(Object data)
        {
            Data = data;
            Next = null;
        }
    }
}
