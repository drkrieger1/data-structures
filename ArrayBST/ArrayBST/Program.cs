using System;

namespace ArrayBST
{
    class Program
    {
        static void Main(string[] args)
        {
            SearchTree ArrTree = new SearchTree();
            int[] arr = new int[] { 4, 8, 15, 16, 23, 42 };
            int l = arr.Length;
            ArrTree.Root = ArrTree.SortedArr(arr, 0, l - 1);
            ArrTree.PreOrder(ArrTree.Root);
            
            Console.Read();
        }
        public class SearchTree
        {
            public Node Root { get; set; }
            public Node SortedArr(int[] arr, int start, int end)
            {
                if (start > end)
                {
                    return null;
                }
                int mid = (start + end) / 2;
                Node node = new Node(arr[mid])
                {
                    Left = SortedArr(arr, start, mid - 1),
                    Right = SortedArr(arr, mid + 1, end)
                };
                return node;
            }
            public void PreOrder(Node node)
            {
                if(node == null)
                {
                    return;
                }
                Console.Write(node.Data + " ");
                PreOrder(node.Left);
                PreOrder(node.Right);
            }
        }
            public class Node
            {
                public int Data { get; set; }
                public Node Left { get; set; }
                public Node Right { get; set; }
                public Node(int data)
                {
                    Data = data;
                    Left = null;
                    Right = null;
                }
            }
    }
}
