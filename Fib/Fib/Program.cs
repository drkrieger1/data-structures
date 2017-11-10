using System;

namespace Fib
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fib find Nth");
            Fib myFib = new Fib();
            myFib.FindNth(5);
            Console.Read();
        }
    }
    public class Fib
    {
        int count;
        int f;

        public void FindNth(int n)
        {
            f = n;
            Console.WriteLine(Find(0, 1));
        }

        public int Find(int a, int b)
        {
            if(count == f)
            {
                return b;
            }
            b = a + b;
            count++;
            if (count == f)
            {
                return b;
            }
            a = b - a;
            count++;
           return Find(a, b);
        }
    }
}
