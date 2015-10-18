using System;
using System.Text;

namespace _05_ChangeCasing
{
    class ChangeCasing
    {
        static string ImplementTag(string text)
        {
            string[] separators = { "<upcase>", "</upcase>" };
            //Splitting the text after every tag. It's important to leave the empty strings, because they
            //let us know the possition of the tagged substrings. If we have a tag in the beggining then we'll have
            //an empty string, and that won't change the placment of the tagged substrings - At every odd index.
            //Note that the code won't work if the input text is invalid regarding proper usage of tags -
            //(an opener tag doesn't end with a closing tag)
            string[] splitText = text.Split(separators, StringSplitOptions.None); 

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < splitText.Length; i++)
            {
                if (i % 2 != 0)
                {
                    result.Append(splitText[i].ToUpper());
                }
                else
                {
                    result.Append(splitText[i]);
                }
            }

            return result.ToString();

            //int lastIndex = splitText.Length - 1;
            //for (int i = 0; i <= lastIndex; i++)
            //{
            //    if (splitText[i] == "<upcase>")
            //    {
            //        if (splitText[i + 1] != "</upcase>" && i + 1 <= lastIndex)
            //        {
            //            result.Append(splitText[i + 1].ToUpper());
            //            i++;
            //        }
            //        else
            //        {
            //            if (i + 1 > lastIndex)
            //            {
            //                throw new IndexOutOfRangeException("Openning tag at the end of the text");
            //            }
            //        }
            //    }
            //    else
            //    {
            //        if (splitText[i] != "</upcase>")
            //        {
            //            result.Append(splitText[i]);
            //        }
            //    }
            //}

            //return result.ToString();
        }

        static void Main()
        {
            string sample = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";

            string result = ImplementTag(sample);
            Console.WriteLine(result);

        }
    }
}
