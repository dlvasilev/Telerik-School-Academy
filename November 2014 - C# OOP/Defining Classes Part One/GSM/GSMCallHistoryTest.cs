using System;

namespace GSM
{
    public static class GSMCallHistoryTest
    {

        public static void TestAddCalls(GSM testPhone)
        {
            testPhone.AddCall(new DateTime(2014, 12, 21, 8, 3, 14), "Pesho", 14); //add some calls
            testPhone.AddCall(new DateTime(2014, 12, 21, 8, 43, 12), "Gosho", 218);
            testPhone.AddCall(new DateTime(2014, 12, 21, 18, 14, 43), "Stamat", 32);
            testPhone.AddCall(new DateTime(2014, 12, 21, 12, 54, 53), "Hasan", 5);
        }

        public static void TestPrintCalls(GSM testPhone)
        {
            testPhone.PrintCalls();
        }

        public static void TestCalcBill(GSM testPhone, double pricePerMin)
        {
            double bill = testPhone.CalcBill(pricePerMin);
            Console.WriteLine("Your bill is: {0:C}",bill);
        }

        public static void TestRemoveLongestCall(GSM testPhone)
        {
            testPhone.RemoveLongestCall();
        }

        public static void TestClearCalls(GSM testPhone)
        {
            testPhone.ClearCalls();
        }


        //Console.WriteLine("Before clear: ");
        //testPhone.PrintCalls();
        //Console.WriteLine();

        //testPhone.ClearCalls();
        //Console.WriteLine("After clear: ");
        //testPhone.PrintCalls();


    }
}
