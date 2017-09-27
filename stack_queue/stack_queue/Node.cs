using System;
using System.Collections.Generic;
using System.Text;

namespace stack_queue
{
    class Node
    {
        public object Data { get; set; }
        public Node Next { get; set; }

        public Node(object data)
        {
            Data = data;
            Next = null;
        }
    }
}
