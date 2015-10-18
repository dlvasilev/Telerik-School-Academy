using System;
using System.Collections.Generic;

namespace _14.Dictonary
{
    class Dictonary
    {
        static void Main()
        {
            IDictionary<string, string> dict = new SortedDictionary<string, string>(); //using dictionary

            dict[".NET"] = "platform for applications from Microsoft";
            dict["CLR"] = "managed execution environment for .NET";
            dict["namespace"] = "hierarchical organization of classes";

            Console.Write("Word: ");
            string word = Console.ReadLine();

            string value;
            if (dict.TryGetValue(word, out value))
            {
                Console.WriteLine("{0} - {1}.", word, value);
            }
            else
            {
                Console.WriteLine("No explanation for the given word.");
            }


        }
    }
}
