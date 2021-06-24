using System;

namespace StrRev
{
    class Program
    {

        static void Main(string[] args)
        {
            /*            string input = Console.ReadLine();*/
            string input = "  a1bcd    efg!h";

            Console.WriteLine(Anagram.ReverseWord(input));
        }
    }
}
