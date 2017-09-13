using System;

namespace strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string startString = "hellos";
            Console.WriteLine(Reversal(startString));
            Console.Read();
        }
        static string Reversal (string myInput)
        {
            string outPut = "";
            for(int i = myInput.Length -1; i >= 0; i--)
            {
                outPut += myInput[i];
            }
            return outPut;
        }
    }
}
