using System;
using System.Collections.Generic;
using System.IO;

namespace Week6Day1_FileIO
{
    public class FileUtility
    {
        public static void CreateFile(string fileName)
        {

            //if no path is predefined file will defualt to bin folder. Example: string filePath = @"C:/users/Darion/Desktop"; @ KW might be needed, which is for string literals
            if (!File.Exists(fileName)) //checking to see if a file exists. We needed to create because if we tried to create again the program crashes
            {
                File.Create(fileName);
            }
        }

        public static void ModifyFile(string filename /*bool canAppend, List<string> LinesOFInput = null*/) // this method will override the file each time the method is called.
        {
            using (StreamWriter writer = new StreamWriter(filename /*canAppend*/)) //using is a keyword.  There to leverage iDisposable after we are done and restoring memory.
            {
                //if (LinesOFInput == null)
                //{

                //    writer.WriteLine("This is an update");
                //}
                //else
                //{
                    var linesOFInput = new List<string>
                    {
                        "7",
                        "12",
                        "13",
                        "15",
                        "12",
                        "11"
                    };
                    foreach (var line in linesOFInput)
                    {
                        writer.WriteLine(line);
                    }
                //}
            }
        }

        public static void ReadFromfile(string fileName)
        {

            
            using (StreamReader reader = new StreamReader(fileName))//opens file
            {
                while (!reader.EndOfStream)
                {
                    Console.WriteLine(reader.ReadLine());
                }
                //This is the old way of doing a read
                //while (true)
                //{
                //    var line = reader.ReadLine();//converts it
                //    if (line == null)
                //    {
                //        break;
                //    }
                //    Console.WriteLine(line);//prints line to console
                //}
            }
        }

        public static void DeleteFile(string FileName)
        {
            File.Delete(FileName);
        }

        public static void TotalNumberFromFile(string fileName)
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                int sum = 0;
                string str = "";
                while (!reader.EndOfStream)
                {
                    string text = reader.ReadLine();
                    int number = int.Parse(text);
                    sum += number;
                    str += number + " + "; 
                }
                str = str.Remove(str.Length - 2, 1);
                Console.WriteLine(str + "= " + sum);
            }
        }
    }
}
//string[] numbers = text.Split("\n");
//int[] NumbersArray = Array.ConvertAll(numbers, n => int.Parse(n));
//int sum = 0;
//for (int i = 0; i < NumbersArray.Length; i++)
//{

//    //NumbersArray[i]++;
//    Console.WriteLine("{0}+", i);
//}