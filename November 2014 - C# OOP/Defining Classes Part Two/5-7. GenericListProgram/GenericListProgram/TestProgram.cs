using System;

namespace GenericListProgram
{
    class TestProgram
    {
        static void Main()
        {
            var list = new GenericList<int>(10);

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);

            Console.WriteLine(list.ToString());

            Console.WriteLine();

            Console.WriteLine("Min: {0}",list.Min());
            Console.WriteLine("Max: {0}",list.Max());

        }
    }
}
