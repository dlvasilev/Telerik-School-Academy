using System;
using System.Collections.Generic;

namespace _20.ExtractPalindroms
{
    class ExtractPalindroms
    {
        static string[] Extract(string text)
        {
            char[] separators = {' ', ',','.','!','?',':',';'};
            string[] words = text.Split(separators,StringSplitOptions.RemoveEmptyEntries);
            List<string> polindroms = new List<string>();

            bool isPolindrom = true;
            foreach (var word in words)
            {
                if (word.Length > 1)
                {
                    isPolindrom = true;
                    for (int i = 0, j = word.Length - 1; i < word.Length / 2; i++, j--)
                    {
                        if (word[i] != word[j])
                        {
                            isPolindrom = false;
                            break;
                        }
                    }
                    if (isPolindrom)
                    {
                        polindroms.Add(word);
                    }
                }           
            }
            return polindroms.ToArray();
        }

        static void Main()
        {
            string sampleText = "Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.";
            string[] polindroms = Extract(sampleText);
            foreach (var word in polindroms)
            {
                Console.WriteLine(word);
            }
        }
    }
}
