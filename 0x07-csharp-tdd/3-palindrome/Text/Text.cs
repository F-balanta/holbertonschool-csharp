using System.Text.RegularExpressions;
using System;

namespace Text
{
    /// <summary>
    /// Vefiry if an string is a palindrome
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Vefiry if an string is a palindrome
        /// </summary>
        /// <param name="s"> string to evaluate</param>
        /// <returns>True or False</returns>
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
