using System;
using System.Collections.Generic;
using System.Text;

namespace TwoStackQ
{
    class TwoStackQ
    {
        Stack one = new Stack();
        Stack two = new Stack();

        public void Queue(object data)
        {   
            if(one.Head == null)
            {
                Console.WriteLine("Stack One \n");
            }
            one.Push(data);

        }
        public void PrintOne()
        {
            one.PrintState();
        }
        public void PrintTwo()
        {
            two.PrintState();
        }

        public void DeQueue()
        {
            Console.WriteLine("\n\n Stack Two \n");

            if(two.Head == null)
            {
                while(one.Head != null)
                {
                    two.Push(one.Pop(true));
                   
                }
            }
            //two.Pop();
        }
        public void Pop()
        {
            two.Pop();
        }
    }
}
