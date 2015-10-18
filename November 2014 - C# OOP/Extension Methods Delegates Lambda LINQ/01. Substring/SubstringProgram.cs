using System;
using System.Linq;
using System.Text;

namespace _01.Substring
{
    static class SubstringProgram
    {
        static StringBuilder Substring(this StringBuilder str, int startIndex, int length)
        {
            return new StringBuilder(str.ToString(startIndex, length));
        }

        static void Main()
        {
            Console.WriteLine(new StringBuilder("Jon Snow is cool! - Ha-ha. Get it? Cool!").Substring(4, 4));
        }
    }
}
