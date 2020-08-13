using System;
using System.Collections.Generic;
using System.IO;

namespace Week6Day1_FileIO
{
    public class Translator
    {
        public string EnglishWord { get; set; }
        public string SpanishWord { get; set; }

        public Translator(string englishWord, string spanishWord)
        {
            EnglishWord = englishWord;
            SpanishWord = spanishWord;
        }

        public static void StoreDictionaryListToDictionary()
        {
            string[] DictionaryFile = File.ReadAllLines(@"/Users/elizabeth/Repos/EH_GC_AHBC_2020/EH_GC_AHBC_2020/Week6Day1_FileIO/bin/Debug/netcoreapp3.1/dictionary");
            Dictionary<string, string[]> Translation = new Dictionary<string, string[]>();
            string key = "";
            List<string> values = new List<string>();

            for (int i = 0; i <= DictionaryFile.Length; i++)
            {
                if (string.IsNullOrEmpty(DictionaryFile[i].Trim()))
                {
                    Translation.Add(key, values.ToArray());
                    key = string.Empty;
                    values = new List<string>();
                }
                else
                {
                    if (key == string.Empty)
                    {
                        key = DictionaryFile[i];
                    }
                    else
                    {
                        values.Add(DictionaryFile[i]);
                    }
                }
            }
            Console.WriteLine(DictionaryFile);
        }
    }
}
