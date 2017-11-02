using System;

namespace Array2D
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        static void FindZero(int[,] array)
        {
            int x = 0;
            int y = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; i++)
                {
                    if (array[i, j] == 0)
                    {
                        x = i;
                        y = j;
                    }
                }
            }
            PaintZero(x, y, array);
        }
        static void PaintZero(int x, int y, int[,] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; i++)
                {
                    if (j == y)
                    {
                        array[i, j] = 0;
                    }
                    if (i == x)
                    {
                        array[i, j] = 0;
                    }
                }
            }
        }
    }
}
