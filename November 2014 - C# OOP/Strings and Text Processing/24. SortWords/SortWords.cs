using System;
using System.Collections.Generic;

namespace _24.SortWords
{
    class SortWords
    {
        static void SortWordsAlpha(string text)
        {
            IDictionary<string, int> dict = new SortedDictionary<string, int>(); 
            char[] seperators = { ' ' };
            string[] words = text.Split(seperators, StringSplitOptions.RemoveEmptyEntries);

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

            foreach (var word in dict) //print every word as many times as it occurs
            {
                for (int i = 0; i < word.Value; i++)
                {
                    Console.Write("{0} ", word.Key);
                }
            }

        }

        static void Main()
        {
            Console.Write("Text: ");
            string text = Console.ReadLine();
            //string sampleText = "goin anus goin tits tits anus goin";
            SortWordsAlpha(text);
        }
    }
}
