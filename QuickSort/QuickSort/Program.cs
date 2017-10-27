using System;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quick Sort");
            int[] array = { 2, 1, 88, 16, 47, 25, 30 };

            QuickSort real = new QuickSort();
            real.Print(array);
            Console.WriteLine();
            
            real.Print(real.Sort(array, 0, array.Length - 1));

            Console.Read();
        }
    }

    class QuickSort
    {
        public int [] Sort(int [] arr, int start, int end)
        {
            if(start < end)
            {
               int i = Partition(arr, start, end);

                Sort(arr, start, i - 1);
                Sort(arr, i + 1, end );
            }
            return arr;
        }

        public int Partition(int [] arr, int start, int end)
        {
            int temp;
            int p = arr[end];
            int i = start - 1;

            for(int j = start; j <= end - 1; j++)
            {
                if (arr[j] <= p)
                {
                    i++;
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
            temp = arr[i + 1];
            arr[i + 1] = arr[end];
            arr[end] = temp;

            return i + 1;
        }
        public void Print(int [] arr)
        {
            foreach(int num in arr)
            {
                Console.Write($"{num} ");
            }
        }
    }
}
