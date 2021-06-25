using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrRev
{
    public class Anagram
    {
        public string Reverse(string s)
        {
            if (s == null || s.Length == 0)
                return s;
            char[] str = s.ToCharArray();

            int l = 0;
            int r = 0;
            while (r <= str.Length)
            {
                if (r == str.Length || str[r] == ' ')
                {
                    ReverseWord(str, l, r - 1);
                    l = r + 1;
                }
                r++;
            }
            return new string(str);
        }
        public void ReverseWord(char[] str, int l, int r)
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
