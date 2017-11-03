using System;

namespace RotateMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Matrix Rotate");

            int row = 3;

            int[,] array = new int[3, 3]
            {
                {1,2,3 },
                {4,5,6 },
                {7,8,9 }
            };
            Print(row, array);
            Console.WriteLine();

            Rotate(row, array);
            Print(row, array);

            Console.Read();
        }
        static void Rotate(int row, int [,] array)
        {
            for(int x = 0; x < row / 2; x++)
            {
                for(int y = x; y < row - x - 1; y++)
                {
                    int temp = array[x, y];

                    array[x, y] = array[y, row - 1 - x];

                    array[y, row-1-x] = array[row-1-x, row-1-y];

                    array[row-1-x, row-1-y] = array[row-1-y, x];

                    array[row - 1 - y, x] = temp;
                }
            }
        }
        static void Print(int row, int[,] array)
        {
            for (int i = 0; i < row; i++)
            {
                for(int j = 0; j < row; j++)
                {
                    Console.Write(" " + array[i, j]);
                   
                }
                Console.WriteLine();
            }
        }
    }
}
