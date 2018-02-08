using System;

namespace StringReversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("String Reversal/ Word Reversal");

            string[] testArray = new string[] {"Hello World", "String Test Working", "1 2 3 4 5 6" };
            foreach(string s in testArray)
            {
                Console.WriteLine($"Input <- {s}");
                Console.WriteLine($"Output -> {Reverse(s)} \n");
            }
           
            Console.Read();           
        }

        static string Reverse(string input)
        {
            input += " ";
            int index = 0;
            string temp = "";
            string result = "";

            for(int i = 0; i < input.Length; i++)
            {
                if(input.Substring(i, 1) != " ")
                {  
                    while(input.Substring(index, 1) != " ")
                    {
                        temp += input.Substring(index, 1);
                        index++;
                    }
                    i = index;
                    temp += input.Substring(index, 1);
                    result = result.Insert(0, $"{temp}");
                    temp = "";
                }
                else
                {
                    result = result.Insert(0, input.Substring(i, 1));
                }
                index++;

            }
            return result.TrimEnd();
        }
    }
}
