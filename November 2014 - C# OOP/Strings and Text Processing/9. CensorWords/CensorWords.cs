using System;
using System.Text.RegularExpressions;

namespace _09.CensorWords
{
    class CensorWords
    {
        static string Censor(string text, string[] words)
        {
            string censoredText = text;
            int wordLenght;
            string tape;
            foreach (var word in words) //make a string with asterixes the lenght of the word. no need of stringbuildier for this.
            {
                wordLenght = word.Length;
                tape = "";
                for (int i = 0; i < wordLenght; i++)
                {
                    tape += "*";
                }
                 censoredText = Regex.Replace(censoredText, word, tape); //use regular expressions for the replacement
            }
            return censoredText;
        }

        static void Main()
        {
            string sampleText = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
            string[] forbiddenWords = { "PHP", "CLR", "Microsoft" };

            string censored = Censor(sampleText, forbiddenWords);
            Console.WriteLine(censored);
        }
    }
}
