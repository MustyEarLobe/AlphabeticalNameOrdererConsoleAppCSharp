using System;
using System.Text.RegularExpressions;

namespace DataManiplator
{
    public static class ManiplatetionData
    {

        static Regex whitelist = new Regex("[^A-Za-z ,]");
        public static void CheckForInvalidInputs(this string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (!whitelist.IsMatch(input))
                {
                    throw new Exception("InvalidNames Input");
                }
            }
        }

        public static string[] OrderString(this string[] StringArray)
        {
            Array.Sort(StringArray);
            Array.Sort(StringArray, (a, b) => a.CompareTo(b));
            return StringArray;
        }
    }
}
