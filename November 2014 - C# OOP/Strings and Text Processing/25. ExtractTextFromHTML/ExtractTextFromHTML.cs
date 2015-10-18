using System;
using System.Collections.Generic;
using System.Text;

namespace _25.ExtractTextFromHTML
{
    class ExtractTextFromHTML
    {

        static string[] ExtractText(string text)
        {
            StringBuilder sb = new StringBuilder();
            List<string> extractedText = new List<string>();
            string[] tags = { "<head>", "</head>", "<body>", "</body>" };

            for (int t = 0; t < tags.Length; t += 2)
            {
                int headOpnIndex = text.IndexOf(tags[t]) + tags[t].Length; //the beginning of the text after the opening tag
                int headClsIndex = text.IndexOf(tags[t + 1]);//...after the closing tag

                bool inTagMode = false;
                if (text[headOpnIndex] == '<') //check if there's an openning tag. pretty much I extract only the text thats not in a tag.
                {
                    inTagMode = true;
                }

                for (int i = headOpnIndex + 1; i < headClsIndex; i++) 
                {
                    if (inTagMode)
                    {
                        if (text[i] == '>')
                        {
                            inTagMode = false;
                        }
                    }
                    else
                    {
                        if (text[i] == '<')
                        {
                            inTagMode = true;
                            sb.Append(' ');
                            continue;
                        }
                        sb.Append(text[i]);
                    }
                }
                
                extractedText.Add(sb.ToString().Trim());
                sb.Clear();
            }
            return extractedText.ToArray();
        }

        static void Main()
        {
            string sampleText = "<html><head><title>News</title></head><body><p><a href=\"http://academy.telerik.com\">Telerik Academy</a>aims to provide free real-world practical training for young people who want to turn into skillful .NET software engineers.</p></body></html>";
            string[] extractedText = ExtractText(sampleText);
            foreach (var blocks in extractedText)
            {
                Console.WriteLine(blocks);
            }
        }
    }
}
