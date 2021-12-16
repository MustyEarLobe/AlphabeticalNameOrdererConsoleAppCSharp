using System;
using System.Collections.Generic;
using System.IO;

namespace AlphabeticalNameOrdererConsoleAppCSharp
{
    static class SaveToFile
    {
        public static string SaveNamesList(this List<string> namesList, string fileLocation, string fileName)
        {
            File.WriteAllLines(fileLocation+"/"+fileName, namesList);
            return "created "+fileName;
        }

    }
}
