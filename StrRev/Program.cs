using System;

namespace StrRev
{
    class Program
    {

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
/*            string input = "  a1bcd    efg!h";*/
            Console.WriteLine("Input  is: " + input);
            Anagram anagram = new();
            Console.WriteLine("Output is: " + anagram.Reverse(input));
        }
    }
}
