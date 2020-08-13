using System;
using System.Collections.Generic;
using System.IO;//All things file related exist here.

namespace Week6Day1_FileIO
{
    class Program
    {
        static void Main(string[] args)
        {

            string dictionaryFile = "dictionary";
            Exercise68_Utility.CreateFile(dictionaryFile);
            Exercise68_Utility.ModifyFile(dictionaryFile);
            Translator.StoreDictionaryListToDictionary();

            //Class work and Exercise 67
            //CreateDarionsFile();
            string numbersFile = "numbers";
            FileUtility.CreateFile(numbersFile);
            FileUtility.ModifyFile(numbersFile);
            //FileUtility.ReadFromfile(numbersFile);
            //Console.WriteLine("--------------------------------");
            FileUtility.TotalNumberFromFile(numbersFile);
        }

        //private static void CreateDarionsFile()
        //{
        //    var fileName = "DarionsFile";
        //    //create
        //    FileUtility.CreateFile(fileName);//This class is creating a new file.  mac cannot specify path.  We don't know why.
        //    //Initial Write
        //    FileUtility.ModifyFile(fileName, true);
        //    var linesOfInput = new List<string>
        //    {
        //        "Darion likes basketball",
        //        "Star Wars is a gift to makekind",
        //        "My birthday is  next week"
        //    };
        //    //modify
        //    FileUtility.ModifyFile(fileName, true, linesOfInput);
        //    //Read
        //    FileUtility.ReadFromfile(fileName);
        //    FileUtility.ModifyFile(fileName, false);
        //}
    }
}
