using System;

namespace GSM
{
    public static class GSMTest
    {
        public static void GSMTestTest()
        {
            Console.WriteLine("GSMTest:");
            GSM[] arrGSM = new GSM[3];

            arrGSM[0] = new GSM("Galaxy Gio", "Samsung", 320);
            arrGSM[1] = new GSM("Google Nexus 4", "LG", 700);
            arrGSM[2] = new GSM("5330M", "Nokia", 180);

             foreach (var gsm in arrGSM)
             {
                 Console.WriteLine("{0} {1} is worth ${2} and is own by {3}", gsm.Manufacturer, gsm.Model, gsm.Price, gsm.Owner);
             }
             Console.WriteLine();

             Console.WriteLine("{0} {1} is worth ${2} and is own by {3}", GSM.IPhone4S.Manufacturer, GSM.IPhone4S.Model, GSM.IPhone4S.Price, GSM.IPhone4S.Owner);

        }
    }
}
