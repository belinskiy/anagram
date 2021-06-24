using System;

namespace StrRev
{
    class Program
    {
        public static void ReverseWord(char[] str)
        {
            // Initialize left and right pointers
            int r = str.Length - 1, l = 0;

            // Traverse string from both ends until 'l' and 'r'
            while (l < r)
            {
                //Ignore special characters
                if (!char.IsLetter(str[l]))
                    l++;
                else if (!char.IsLetter(str[r]))
                    r--;

                //Both str[l] and str[r] are not special
                else
                {
                    char tmp = str[l];
                    str[l] = str[r];
                    str[r] = tmp;
                    l++;
                    r--;
                }
            }
        }
        static void Main(string[] args)
        {
            string input = "  a1bcd    efg!h";
            char[] charArray = input.ToCharArray();

            Console.WriteLine("Input string: " + input);

            ReverseWord(charArray);

            string output = new string(charArray);

            Console.WriteLine("Output string: " + output);
        }
    }
}
