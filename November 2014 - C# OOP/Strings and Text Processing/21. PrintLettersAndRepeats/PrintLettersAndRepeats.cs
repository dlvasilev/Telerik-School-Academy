using System;
using System.Collections;
using System.Collections.Generic;

namespace _21.PrintLettersAndRepeats
{
    class PrintLettersAndRepeats
    {
        static void SplitNCountLetters(string text)
        {
            IDictionary<char,int> dict = new SortedDictionary<char,int>();

            for (int i = 0; i < text.Length; i++)
			{
			    if (char.IsLetter(text[i])) //we want only letters, so...
                {
                    if (!dict.ContainsKey(text[i])) //if the letter hasn't occured yet, add it
                    {
                        dict.Add(text[i], 1);
                    }
                    else                            //if it has, increase the value by 1
                    {
                        dict[text[i]] += 1;
                    }
                }
			}

            foreach (var word in dict) // print result
            {
                Console.WriteLine("{0} - {1}",word.Key, word.Value);
            }
        }

        static void Main()
        {
            Console.Write("Text: ");
            string text = Console.ReadLine();
            //string sampleText = "sample string. really no need to get it from the console.";
            SplitNCountLetters(text);

        }
    }
}
