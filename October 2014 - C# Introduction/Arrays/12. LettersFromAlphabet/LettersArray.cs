using System;

// Write a program that creates an array containing all letters from the alphabet (A-Z). Read a word from the console and print the index of each of its letters in the array.


namespace _12.LettersFromAlphabet
{
    class LettersArray
    {
        static void Main()
        {
            char[] alphabet = new char[26];

            for (int i = 0; i < alphabet.Length; i++)
            {
                alphabet[i] = (char)('a' + i);
            }

            Console.Write("Word: ");
            string word = Console.ReadLine().ToLower();

            foreach (char letter in word)
            {
                for (int i = 0; i < alphabet.Length; i++)
                {
                    if (letter == alphabet[i])
                    {
                        Console.WriteLine("'{0}' is at {1} place in the Alphabet", letter, i);
                    }
                }
            }
        }
    }
}
