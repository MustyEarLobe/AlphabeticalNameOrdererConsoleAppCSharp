using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

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

        public static List<string> OrderNameStrings(this List<string> nameStringArray)
        {
            var sortedList = nameStringArray.OrderBy(x => x).ToList();
            return sortedList;
        }
    }
}
