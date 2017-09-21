using System;
using System.Collections.Generic;
using System.Text;

namespace linked_list_find_enth
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
