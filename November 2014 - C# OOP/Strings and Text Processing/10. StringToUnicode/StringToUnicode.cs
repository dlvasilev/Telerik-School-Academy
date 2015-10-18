using System;
using System.Text;

namespace _10.StringToUnicode
{
    class StringToUnicode
    {
        static string ConvertToUnicode(string text)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var character in text)
            {
                sb.AppendFormat("\\u{0:X4}", (int)character);
            }
            return sb.ToString();
        }

        static void Main()
        {
            string sampleText = "Hi!";
            string converted = ConvertToUnicode(sampleText);
            Console.WriteLine(converted);
        }
    }
}
