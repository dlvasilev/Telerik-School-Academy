using System;
using System.Text;
namespace _23.RemoveRepeats
{
    class RemoveRepeats
    {
        static string RemoveRepeatedSymbols(string text)
        {
            StringBuilder sb = new StringBuilder();
            char currentSymbol = text[0];
            sb.Append(currentSymbol);
            for (int i = 1; i < text.Length; i++)
            {
                if (text[i] != currentSymbol)
                {
                    sb.Append(text[i]);
                    currentSymbol = text[i];
                }
            }

            return sb.ToString();

        }

        static void Main()
        {
            string sampleText = "aaaaabbbbbcdddeeeedssaa";
            Console.WriteLine(RemoveRepeatedSymbols(sampleText));
        }
    }
}
