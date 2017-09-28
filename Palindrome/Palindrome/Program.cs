using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palindrome");

            Doubly_list myList = new Doubly_list();
            string word = "tacocat";

            myList.Converter(word);

            myList.Print();
            Console.WriteLine($"\n {myList.Check()}");

            Doubly_list list2 = new Doubly_list();
            String word2 = "hellow";

            list2.Converter(word2);
            Console.WriteLine();
            list2.Print();
            Console.WriteLine($"\n {list2.Check()}");

            Console.Read();

        }
    }
}
