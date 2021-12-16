using System;
using DataManiplator;
using System.Collections.Generic;
using System.Linq;

namespace AlphabeticalNameOrdererConsoleAppCSharp
{
    static class Program
    {
        static List<string> Inputs;
        static string fileLocation = "C:";
        static string fileName = "names.txt";

        static void Main(string[] args)
        {
            Inputs = new List<string>();
            try
            {
                SortPrintandSave();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        static void SortPrintandSave()
        {
            CheckIfLineIsInputed();

            Console.WriteLine("sort-names " + fileLocation + "/" + fileName);
            Inputs.CheckForInvalidInputs();

            var sortedNames = Inputs.OrderString();

            PrintNamesArray(sortedNames);

            string saveFileOutputMsg = sortedNames.SaveNamesList(fileLocation, fileName);
            Console.WriteLine("Finished: " + saveFileOutputMsg);
        }


        static void CheckIfLineIsInputed()
        {
            string input = Console.ReadLine();
            if (input != string.Empty)
            {
                string valuething = input;
                Inputs.Add(valuething);
                CheckIfLineIsInputed();
            }
            return;
        }

        static void PrintNamesArray(List<string> NamesArray)
        {
            for (int i = 0; i < NamesArray.Count; i++)
            {
                Console.WriteLine(NamesArray[i]);
            }
        }

    }
}
