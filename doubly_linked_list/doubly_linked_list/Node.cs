using System;
using System.Collections.Generic;
using System.Text;

namespace doubly_linked_list
{
    class Node
    {
        public Node Next { get; set; }
        public object Data { get; set; }
        public Node Prev { get; set; }

        public Node(object data)
        {
            Next = null;
            Data = data;
            Prev = null;
        }

    }
}
