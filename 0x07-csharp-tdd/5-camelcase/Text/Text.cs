using System;

namespace Text
{
    /// <summary>
    ///  1 method
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Write a method that determines how many words are in a string.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int CamelCase(string s)
        {
            int total = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (i == 0 || Char.IsUpper(s[i]))
                    total++;
            }
            return (total);
        }
    }
}
