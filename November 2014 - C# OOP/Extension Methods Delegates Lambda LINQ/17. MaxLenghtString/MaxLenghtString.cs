using System;
using System.Linq;

namespace _17.MaxLenghtString
{
    class MaxLenghtString
    {
       static void Main()
        {
            string[] strings = new string[]
            {
                "Word", "something","went","sentence" 
            };

            var bestLen = strings.OrderByDescending(str => str.Length).First();
            Console.WriteLine(bestLen);
        }
    }
}
