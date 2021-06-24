using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrRev
{
    class Anagram
    {
        public static string ReverseWord(string s)
        {
            if (s == null || s.Length == 0)
                return s;
            char[] str = s.ToCharArray();

            int i = 0;
            int j = 0;
            while (j <= str.Length)
            {
                if (j == str.Length || str[j] == ' ')
                {
                    Reverse(str, i, j - 1);
                    i = j + 1;
                }
                j++;
            }
            return new string(str);
        }
        public static void Reverse(char[] str, int l, int r)
        {
            while (l < r)
            {
                //Ignore special characters
                if (!char.IsLetter(str[l]))
                {
                    l++;
                }
                else if (!char.IsLetter(str[r]))
                {
                    r--;
                }
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
    }
}
