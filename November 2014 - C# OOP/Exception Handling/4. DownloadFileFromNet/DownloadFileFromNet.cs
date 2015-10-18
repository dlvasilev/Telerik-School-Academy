using System;
using System.Net;

namespace _04.DownloadFileFromNet
{
    class DownloadFileFromNet
    {
        static void DownloadFile(string remoteUri, string fileName)
        {
            WebClient myWebClient = new WebClient();
            string myStringWebResource = null;
            try
            {
                myStringWebResource = remoteUri + fileName;
                Console.WriteLine("Downloading File \"{0}\" from \"{1}\" .......\n\n", fileName, myStringWebResource);
                myWebClient.DownloadFile(myStringWebResource, fileName);		
            }
            catch (WebException)
            {
                Console.WriteLine("Invalid url adress.");
            }
            finally
            {
                myWebClient.Dispose();
            }           
        }

        static void Main()
        {
            string remoteUri = @"http://www.devbg.org/img/";
            string fileName = "Logo-BASD.jpg";
            DownloadFile(remoteUri, fileName);           
        }
    }
}
