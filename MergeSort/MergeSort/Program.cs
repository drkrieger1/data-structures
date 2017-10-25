using System;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merge Sort");
            int[] works = { 5, 9, 52, 6, 25, 64, 2 };

            Merge myMerge = new Merge();

            myMerge.SortMethod(works, 0, (7 - 1));
            myMerge.Print(works);

        }
    }

    class Merge
    {
        public void SortMethod(int[] numbers, int left, int right)
        {
            int len = numbers.Length - 1;
            int mid;
            if (right > left)
            {
                mid = (right + left) / 2;
                SortMethod(numbers, left, mid);
                SortMethod(numbers, (mid + 1), right);
                MergeMethod(numbers, left, (mid + 1), right);
            }
        }
        public void MergeMethod(int[] arr, int left, int mid, int right)
        {
            int[] temp = new int[25];
            int i, left_end, num_elements, tmp_pos;
            left_end = (mid - 1);
            tmp_pos = left;
            num_elements = (right - left + 1);
            while ((left <= left_end) && (mid <= right))
            {
                if (arr[left] <= arr[mid])
                {
                    temp[tmp_pos++] = arr[left++];
                }
                else
                {
                    temp[tmp_pos++] = arr[mid++];
                }
            }
            while (left <= left_end)
            {
                temp[tmp_pos++] = arr[left++];
            }
            while (mid <= right)
            {
                temp[tmp_pos++] = arr[mid++];
            }
            for (i = 0; i < num_elements; i++)
            {
                arr[right] = temp[right];
                right--;
            }
        }

        public void Print(int[] numbers)
        {
            int len = numbers.Length;
            for (int i = 0; i < len; i++)
                Console.Write($"{numbers[i]} ");
            Console.Read();
        }
    }
}
