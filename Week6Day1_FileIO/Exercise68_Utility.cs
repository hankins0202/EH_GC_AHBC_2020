using System;
using System.Collections.Generic;
using System.IO;

namespace Week6Day1_FileIO
{
    public class Exercise68_Utility
    {
        public static void CreateFile(string fileName)
        {
            if (!File.Exists(fileName))
            {
                File.Create(fileName);
            }
        }

        public static void ModifyFile(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {

                var linesOfInput = new List<string>
                {
                    "hello,hola",
                    "food,comida",
                    "world,mundo",
                    "computer,computadora",
                    "exercise,ejercicio",
                };
                foreach (var line in linesOfInput)
                {
                    writer.WriteLine(line);
                }
            }
        }
    }
}
