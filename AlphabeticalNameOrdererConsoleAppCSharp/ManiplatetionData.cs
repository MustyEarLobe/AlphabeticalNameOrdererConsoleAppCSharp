using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace DataManiplator
{
    public static class ManiplatetionData
    {

        static Regex namesWhitelist = new Regex(@"^[A-Za-z,\s]*$");
        public static void CheckForInvalidInputs(this List<string> input)
        {
            if (input.Count == 0)
            {
                throw new Exception("No Names Were Input");
            }

            for (int i = 0; i < input.Count; i++)
            {
                if (!namesWhitelist.IsMatch(input[i]))
                {
                    throw new Exception("Invalid Names Input");
                }
            }
        }

        public static List<string> OrderString(this List<string> StringArray)
        {
            Array.Sort(StringArray.ToArray(), (a, b) => a.CompareTo(b));
            return StringArray;
        }
    }
}
