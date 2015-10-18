using System;
using System.Collections.Generic;

namespace _08.ExtractSentences
{
    class ExtractSentences
    {
        //Checking if the word is not surrounded by letters.
        static void CheckIfAWord(int index, string word, string sentence, List<string> containingWord, bool found)
        {
            char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            index = sentence.IndexOf(word, index + 1); //get the first occurrence and check for it.

            //On the left
            if (index > 0) 
            {
                foreach (var letter in letters)
                {
                    if (sentence[index - 1].Equals(letter))
                    {
                        found = false;
                        //If it's not a single word, then check again if there's another occurrence.
                        CheckIfAWord(index, word, sentence, containingWord, found); 
                        return;
                    }
                    else
                    {
                        found = true;
                    }
                }
            }
            //On the right
            if (index + word.Length + 1 < sentence.Length && index != -1)
            {
                foreach (var letter in letters)
                {
                    if (sentence[index + word.Length].Equals(letter))
                    {
                        found = false;
                        CheckIfAWord(index, word, sentence, containingWord, found);
                        return;
                    }
                    else
                    {
                        found = true;
                        AddSentence(sentence, containingWord);
                        return;
                    }
                }
            }
        }

        static void AddSentence(string sentence, List<string> containingWord)
        {
            containingWord.Add(sentence);
        }

        static List<string> SentencesContaingWord(string text, string word)
        {
            string[] seperator = { ". " };
            string[] sentences = text.Split(seperator, StringSplitOptions.RemoveEmptyEntries); //split into sentences

            List<string> containingWord = new List<string>(); //list for the searched sentences
            bool found = true;
            foreach (var sentence in sentences) // loop for every sentence
            {
                CheckIfAWord(-1, word, sentence, containingWord, found);
            }

            return containingWord;
        }

        static void Main()
        {
            string sample = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            string word = "in";


            List<string> result = SentencesContaingWord(sample, word);

            foreach (var sentence in result)
            {
                Console.WriteLine(sentence);
            }

        }
    }
}
