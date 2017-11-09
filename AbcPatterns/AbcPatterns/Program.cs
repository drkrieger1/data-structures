using System;
using System.Text.RegularExpressions;

namespace AbcPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string[] aph = Regex.Split("abcdefghijklmnopqrstuvwxyz", string.Empty);
            Converter.Print(aph, 3);
            Console.Read();
        }
    }
    public class Converter
    {
        public static void Print(string [] array, int num)
        {
            string[] copy = new string[num];
            Array.Copy(array, 1, copy, 0, num);
            string pointer;
            int counter = 0;
            for(int i = 0; i< num; i++)
            {
               pointer = copy[i];
                Console.Write(pointer);
               while(counter < copy.Length)
                {
                    if(pointer != copy[counter])
                    {
                        Console.Write(copy[counter]);
                        counter++;
                    } else
                    {
                        counter++;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
