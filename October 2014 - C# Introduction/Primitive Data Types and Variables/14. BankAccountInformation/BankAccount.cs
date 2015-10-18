using System;
using System.Numerics;

// A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, BIC code and 3 credit card numbers associated with the account. Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.

namespace _14.BankAccountInformation
{
    class BankAccount
    {
        static void Main()
        {
            Console.Write("Holder name: ");
            string holderName = Console.ReadLine();

            Console.Write("Balance: ");
            decimal balance = decimal.Parse(Console.ReadLine());

            Console.Write("Bank name: ");
            string bankName = Console.ReadLine();

            Console.Write("IBAN: ");
            string iban = Console.ReadLine();

            Console.Write("BIC code: ");
            int bicCode = int.Parse(Console.ReadLine());

            Console.Write("Credit card one: ");
            BigInteger cardOne = BigInteger.Parse(Console.ReadLine());

            Console.Write("Credit card two: ");
            BigInteger cardTwo = BigInteger.Parse(Console.ReadLine());

            Console.Write("Credit card three: ");
            BigInteger cardThree = BigInteger.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Bank Account information:");
            Console.WriteLine("Holder name: {0}", holderName);
            Console.WriteLine("Balance: {0}", balance);
            Console.WriteLine("Bank name: {0}", bankName);
            Console.WriteLine("IBAN: {0}", iban);
            Console.WriteLine("BIC code: {0}", bicCode);
            Console.WriteLine("Credit card one: {0}", cardOne);
            Console.WriteLine("Credit card two: {0}", cardTwo);
            Console.WriteLine("Credit card three: {0}", cardThree);
        }
    }
}
