using System;

namespace _15.ReplaceHTMLTags
{
    class ReplaceHTMLTags
    {
        static string ReplaceTags(string text)
        {   //Could be done with a dictionary, but there's really no need for just three replacements.
            string[,] htmlTags = new string[2,3] { { "a href=\"", "\">", "</a>" },
                                                   { "[URL=", "] ","[/URL] " } }; //added whitespaces next to the closing tags for readability
            for (int i = 0; i < 3; i++)
            {
               text = text.Replace(htmlTags[0, i], htmlTags[1, i]);
            }
            return text;
        }

        static void Main()
        {
            string sampleText = "<p>Please visit <a href=\"http://academy.telerik. com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";
            string editedText = ReplaceTags(sampleText);
            Console.WriteLine(editedText);
        }
    }
}
