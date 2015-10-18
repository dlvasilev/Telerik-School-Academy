using System;

// Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?

class DeclareAppropriateType
{
    static void Main()
    {
        double a = 34.567839023D;
        float b = 12.345F;
        double c = 8923.1234857D;
        float d = 3456.091F;

        Console.WriteLine("{0} {1} {2} {3}", a, b, c, d);
    }
}

