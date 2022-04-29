using System;

namespace Text
{
    /// <summary>
    /// Class with 1 method public
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Method that returns the index of the first non-repeating character of a string.
        /// </summary>
        /// <param name="s">String to evaluate</param>
        /// <returns>returns the index of the first non-repeating character of a string.</returns>
        public static int UniqueChar(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < s.Length; j++)
                {
                    if (i != j)
                    {
                        if (s[i] == s[j])
                        {
                            break;
                        }
                        else if (j == s.Length - 1 && s[i] != s[j])
                        {
                            return (i);
                        }
                    }
                    else if (i == s.Length - 1)
                    {
                        return (i);
                    }
                }
            }
            return (-1);
        }
    }
}
