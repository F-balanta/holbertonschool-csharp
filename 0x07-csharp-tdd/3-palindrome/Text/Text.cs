using System.Text.RegularExpressions;
using System;

namespace Text
{
    public class Str
    {
        public static bool IsPalindrome(string s)
        {
            if (s.Length == 0)
                return true;
            string reverse;
            reverse = String.Empty;
            foreach (char characters in s)
            {
                reverse = characters + reverse;
            }
            reverse = Regex.Replace(reverse, @"[^\w]", "");
            s = Regex.Replace(s, @"[^\w]", "");
            if (s.ToUpper() == reverse.ToUpper())
                return true;
            return false;
        }
    }
}
