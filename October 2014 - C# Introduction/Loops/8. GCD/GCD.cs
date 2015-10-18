using System;

// Write a program that calculates the greatest common divisor (GCD) of given two numbers. Use the Euclidean algorithm

namespace _8.GCD
{
    class GCD
    {
        static void Main()
        {
            uint N, K, temporary, remaining;
            uint gcd = 1;

            Console.Write("Enter the first number N:");
            bool isNUint = uint.TryParse(Console.ReadLine(), out N);

            Console.Write("Enter the second number K:");
            bool isKUint = uint.TryParse(Console.ReadLine(), out K);

            if (isNUint && isKUint && (N != 0 || K != 0))
            {
                if (N == 0)
                {
                    gcd = K;
                }
                else if (K == 0)
                {
                    gcd = N;
                }
                else
                {
                    temporary = Math.Max(N, K);
                    K = Math.Min(N, K);
                    N = temporary;
                    do
                    {
                        remaining = N % K;
                        if (remaining == 0)
                        {
                            gcd = K;
                            break;
                        }
                        else
                        {
                            N = K;
                            K = remaining;
                        }
                    } while (true);
                }
                Console.WriteLine("Greatest common devider = {0}", gcd);
            }
            else
            {
                Console.WriteLine("Not a valid entry!");
            }
        }
    }
}
