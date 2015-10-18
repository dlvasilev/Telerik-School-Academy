using System;

namespace _03.CorrectnessOfBrackets
{
    class CorrectnessOfBrackets
    {
        static bool CheckIfValid(string equation)
        {
            var counter = 0; //counter for the single opening and closing brackects.

            foreach (var item in equation)
            {
                if (item == '(') { counter++; }; //if we encounter an opening bracket we increese the counter
                if (item == ')') { counter--; }; //if we find a closing we decreese it.
            }

            //If the counter is 0, that means that all brackets are paired.
            if (counter == 0) { return true; }
            else { return false; };

            //sorry for the short if statement
        }

        static void Main()
        {
            string sample = "((a+b)/5-d)";
            //string sample = ")(a+b))";

            bool valid = CheckIfValid(sample);
            Console.WriteLine(valid);
        }
    }
}
