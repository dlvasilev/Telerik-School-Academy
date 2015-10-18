using System;

namespace _04.CountSubstringRepeats
{
    class CountSubstringRepeats
    {

        static int CountRepeatedSubstrings(string substring, string text)
        {
            int counter = 0;
            int index = text.IndexOf(substring, 0); //get the index of the first encouter
            if (index == -1) //if the substring is not found in the text, return.
            {
                return counter;
            }
            else
            {
                counter++;
            }

            while (index != -1) //repeat the search untill there are no more substrings to be found
            {
                index = text.IndexOf(substring, index + 1); //when a substring is found, get its index and start the next search from that index + 1
                counter++;
            }

            return counter;
        }

        static void Main()
        {
            string sampleText = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            Console.Write("substring: ");
            string substring = Console.ReadLine();

            int repeats = CountRepeatedSubstrings(substring, sampleText);
            Console.WriteLine(repeats);

        }
    }
}
