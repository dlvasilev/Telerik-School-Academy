namespace GSM
{
    using System;
    class Tests
    {
        static void Main()
        {
            Console.WriteLine("First test.");
            GSMTest.GSMTestTest();
            Console.WriteLine();

            Console.WriteLine("CallHistoryTest:");
            GSM testPhone = new GSM("X", "HTC");

            GSMCallHistoryTest.TestAddCalls(testPhone);

            GSMCallHistoryTest.TestPrintCalls(testPhone);

            GSMCallHistoryTest.TestCalcBill(testPhone, 0.37);

            GSMCallHistoryTest.TestRemoveLongestCall(testPhone);
            GSMCallHistoryTest.TestCalcBill(testPhone, 0.37);

            GSMCallHistoryTest.TestClearCalls(testPhone);
            GSMCallHistoryTest.TestPrintCalls(testPhone);

        }
    }
}
