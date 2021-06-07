using System.Collections.Generic;

namespace IsomorphicStrings
{
    /// <summary>
    /// Given two strings s and t, determine if they are isomorphic.
    /// Two strings s and t are isomorphic if the characters in s can be replaced to get t.
    /// All occurrences of a character must be replaced with another character while 
    /// preserving the order of characters.No two characters may map to the same character, 
    /// but a character may map to itself.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var prg = new Program();
            var result1 = prg.IsIsomorphic("egg", "add"); //true;
            var result2 = prg.IsIsomorphic("foo", "bar"); //true;
        }

        public bool IsIsomorphic(string s, string t)
        {
            if (s == null || t == null)
                return false;

            if (s.Length != t.Length)
                return false;

            var data = new Dictionary<char, char>();

            for (int i = 0; i < s.Length; i++)
            {

                if (!data.ContainsKey(s[i]))
                {

                    if (data.ContainsValue(t[i]))
                        return false;
                    else
                        data.Add(s[i], t[i]);
                }
                else
                {
                    if (data[s[i]] != t[i])
                        return false;
                }
            }

            return true;
        }
    }
}
