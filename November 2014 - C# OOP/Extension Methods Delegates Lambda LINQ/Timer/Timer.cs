using System;
using System.Threading;

namespace Timer
{
    class Timer
    {
        static void SetInterval(Action f, int t)
        {
            while (true)
            {
                Thread.Sleep(t * 1000);

                f();
            }
        }

        static void Main()
        {
            SetInterval(new Action(() =>
                Console.WriteLine(DateTime.Now)
            ), 1);
        }
    }
}
