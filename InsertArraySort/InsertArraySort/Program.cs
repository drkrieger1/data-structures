using System;

namespace InsertArraySort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert Sort");

            InsertSort myArraySort = new InsertSort();
            int[] monday = {10, 25, 14, 9, 32, 73};

            myArraySort.Sort(monday);
            Console.Read();
        }
    }

    class InsertSort
    {   //This is 
        public void Sort(int [] array)
        {
            for(int i = 1; i < array.Length; i++)
            {
                int key = array[i];
                int j = i - 1;

                while(j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = key;
            }
            Print(array);
        }

        public void Print(int [] array)
        {
            foreach(var item in array)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
