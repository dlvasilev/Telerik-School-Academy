using System;

namespace _01.CalcSquareRoot
{
    class CalcSquareRoot
    {
        static void Main()
        {
            try
            {
                Console.Write("number: ");
                uint number = uint.Parse(Console.ReadLine());
                Console.WriteLine(Math.Sqrt(number));
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Invalid number");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
