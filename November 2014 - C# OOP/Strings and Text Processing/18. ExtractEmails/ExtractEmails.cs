using System;
using System.Collections.Generic;
using System.Text;

namespace _18.ExtractEmails
{
    class ExtractEmails
    {
        static string[] ExtractEmailAdresses(string text)
        {
            List<string> emails = new List<string>();
            StringBuilder sb = new StringBuilder();

            int index = -1; //-1, so i can begin search from index 0
            int wordStart, wordEnd;
            do
            {
                index = text.IndexOf('@', index + 1); //if found a '@', extraxt the substring
                if (index != -1)
                {
                    wordStart = text.LastIndexOf(' ', index); //get its start
                    wordEnd = text.IndexOf(' ', index); //and end index

                    for (int i = wordStart + 1; i < wordEnd; i++) //build it
                    {
                        sb.Append(text[i]);
                    }
                    ValidateEmail(sb.ToString(),emails); //validate it
                    sb.Clear();
                }            
            }
            while (index != -1);
            return emails.ToArray();
        }

        static List<string> ValidateEmail(string email, List<string> list) //can be optimized if I work with the text and start/end indexex of the mail.
        {
            //I validate it by checking if we have only one '@', a dot after it, and some other text after the dot.
            int index = email.IndexOf('@');
            for (int i = index + 1; i < email.Length; i++)
            {
                if (email[i] == '@')
                {
                    return list;
                }
            }

            index = email.IndexOf('.', index + 1);
            if (index == -1 || index == email.Length - 1)
            {
                return list;
            }

            list.Add(email);
            return list;
        }

        static void Main()
        {
            string sampleText = "Lorem ipsum dolor sit amet - gosho@abv.bg consectetur ninja@gmail.com adipiscing elit. Nulla sit amet metus pesho_sexa@qksam.net at lacus bibendum varius.";
            string[] emails = ExtractEmailAdresses(sampleText);
            foreach (var email in emails)
            {
                Console.WriteLine(email);
            }
        }
    }
}
