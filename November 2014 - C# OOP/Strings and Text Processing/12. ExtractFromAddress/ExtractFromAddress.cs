using System;
using System.Text;

namespace _12.ExtractFromAddress
{
    class ExtractFromAddress
    {

        static string[] Extraxt(string address)
        {
            string[] info = new string[3];
            StringBuilder sb = new StringBuilder();

            int firstSepIndex = address.IndexOf("://"); //index of the first seperator
            int secondSepIndex = address.IndexOf('/', firstSepIndex + 3); //index of the second separator

            for (int i = 0; i < firstSepIndex; i++) //protocol
            {
                sb.Append(address[i]);
            }
            info[0] = sb.ToString();
            sb.Clear();

            for (int i = firstSepIndex + 3; i < secondSepIndex; i++) //server
            {
                sb.Append(address[i]);
            }
            info[1] = sb.ToString();
            sb.Clear();

            for (int i = secondSepIndex; i < address.Length; i++) //resource
            {
                sb.Append(address[i]);
            }
            info[2] = sb.ToString();

            return info;
        }

        static void Main()
        {
            string sampleAddress = "http://www.devbg.org/forum/index.php";
            string[] extractedInfo = Extraxt(sampleAddress);

            foreach (var item in extractedInfo)
            {
                Console.WriteLine(item);
            }

        }
    }
}
