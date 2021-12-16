using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


namespace AlphabeticalNameOrdererConsoleAppCSharp
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

        public static List<string> OrderNameStrings(this List<string> StringList)
        {
            var sortedList = StringList.OrderBy(x => x).ToList();
        
            return sortedList;
        }
    }
}
