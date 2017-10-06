using System;
using System.Collections.Generic;
using System.Text;

namespace BreathFirst
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

        public void BreadthFirst()
        {
            Queue<Tree> q = new Queue<Tree>();
            q.Enqueue(this);

            while (q.Count > 0)
            {
                Tree t = q.Dequeue();
                Console.Write(t.Data);

                if (t.Left != null)
                {
                    q.Enqueue(t.Left);
                }

                if (t.Right != null)
                {
                    q.Enqueue(t.Right);
                }
            }
        }
    }
}
