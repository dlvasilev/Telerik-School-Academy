using System;
using System.Text;

namespace _07.TheImitationGame //- It's gonna be a nice movie. You should watch it.
{
    class TheImitationGame 
    {
        static string EncryptMessage(string message)
        {
            string encryptionKey = "#*@*%#!!#&#@&^#%@%@!!"; //The secret encryption key, only visible in the method.

            //Building the encrypted message. During the ecnryption there may occur new lines. They are part of the encrypted message.
            char[] encryptedMsg = new char[message.Length]; 
            for (int i = 0, j = 0; i < message.Length; i++, j++)
            {
                if (j >= encryptionKey.Length)
                {
                    j = 0;
                }
                encryptedMsg[i] = (char)(message[i] ^ encryptionKey[j]);
            }

            StringBuilder encryptedMsgStr = new StringBuilder(); 
            foreach (var item in encryptedMsg)
            {
                encryptedMsgStr.Append(item);
            }
            return encryptedMsgStr.ToString();
        }

        static string DecryptMessage(string encryptedMessage, string encryptionKey)
        {
            char[] decryptedMsg = new char[encryptedMessage.Length];
            for (int i = 0, j = 0; i < encryptedMessage.Length; i++, j++)
            {
                if (j >= encryptionKey.Length)
                {
                    j = 0;
                }
                decryptedMsg[i] = (char)(encryptedMessage[i] ^ encryptionKey[j]);
            }

            StringBuilder decryptedMsgStr = new StringBuilder();
            foreach (var item in decryptedMsg)
            {
                decryptedMsgStr.Append(item);
            }
            return decryptedMsgStr.ToString();
        }

        static void Main()
        {
            string secretMessage = "Plan is a Go. Telerik Academy. 18th of December. 10 a.m.";

            string encrypted = EncryptMessage(secretMessage);
            Console.WriteLine(encrypted);

            //Naturally to decrypt the message you must know the encryption key yourself. 
            //You shouldn't be able to get it from the encryption method.
            string encryptionKey = "#*@*%#!!#&#@&^#%@%@!!"; 
            string decrypted = DecryptMessage(encrypted, encryptionKey);
            Console.WriteLine(decrypted);


        }
    }
}
