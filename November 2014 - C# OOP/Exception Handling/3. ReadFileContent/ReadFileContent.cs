using System;
using System.IO;

namespace _03.ReadFileContent
{
    class ReadFileContent
    {
        static string ReadText(string path)
        {
            string readText = File.ReadAllText(path);
            return readText;
        }

        static void Main()
        {
            string path = @"C:\WINDOWS\win.ini";

            try
            {
                string text = ReadText(path);
                Console.WriteLine(text);
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("The file path contains a directory that cannot be found!");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file '{0}' was not found!", path);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("No file path is given!");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("The entered file path is not correct!");
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("The entered file path is too long - 248 characters are the maximum!");
            }
            catch (UnauthorizedAccessException uoae)
            {
                Console.WriteLine(uoae.Message);
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("Invalid file path format!");
            }
            catch (IOException ioe)
            {
                Console.WriteLine(ioe.Message);
            }
        }
    }
}