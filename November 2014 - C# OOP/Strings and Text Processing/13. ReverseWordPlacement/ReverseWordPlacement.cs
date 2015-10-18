using System;
using System.Text.RegularExpressions;
using System.Text;

namespace _13.ReverseWordPlacement
{
    class ReverseWordPlacement
    {

        static string ReverseWords(string text)
        {
            string[] splitWords = Regex.Split(text, @"(?=[ .,!?])"); //using regular expression to keep the sepertors
            splitWords[0] = " " + splitWords[0]; //put a white space before the first word... looks better.
            string[] sighs = { "!", ",", ".", "?" }; //looking at the example, the sighs should stay in place

            string temp;
            for (int i = 0, j = splitWords.Length - 1; i < j; i++, j--)
            {
                foreach (var ch in sighs) //if we find a sigh we skip it
                {
                    if (splitWords[i] == ch)
                    {
                        i++;
                    }
                    if (splitWords[j] == ch)
                    {
                        j--;
                    }
                }
                temp = splitWords[i]; //else, we swap the leftmost with the rightmost unchecked word
                splitWords[i] = splitWords[j];
                splitWords[j] = temp;
            }

            StringBuilder sb = new StringBuilder(); //"string that array"
            foreach (var word in splitWords)
            {
                sb.Append(word);
            }

            return sb.ToString().Trim();

        }

        static void Main()
        {
            string sampleText = "C# is not C++, not PHP and not Delphi!";
            string reversed = ReverseWords(sampleText);
            Console.WriteLine(reversed);
        }
    }
}
