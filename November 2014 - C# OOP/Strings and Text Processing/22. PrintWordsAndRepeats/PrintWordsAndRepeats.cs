using System;
using System.Collections;
using System.Collections.Generic;

namespace _22.PrintWordsAndRepeats
{
    class PrintWordsAndRepeats
    {
        static void AddWords(string text)
        {
            IDictionary<string, int> dict = new SortedDictionary<string, int>();
            char[] separators = { ' ', ',', '.', '!', '?', ':', ';' };
            string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in words)
            {
                if (!dict.ContainsKey(word))
                {
                    dict.Add(word, 1);
                }
                else
                {
                    dict[word] += 1;
                }
            }

            foreach (var key in dict)
            {
                Console.WriteLine("{0} - {1}",key.Key, key.Value);
            }

        }

        static void Main()
        {
            Console.Write("Text: ");
            string text = Console.ReadLine();
            //string sampleText = "Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.";
            AddWords(text);
        }
    }
}
