using System;

// Write a program that prints all possible cards from a standard deck of 52 cards (without jokers). The cards should be printed with their English names. Use nested for loops and switch-case.

namespace _11.CardDeck
{
    class CardDeck
    {
        static void Main()
        {
            for (int i = 1; i <= 13; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    switch (i)
                    {
                        case 1:
                            Console.Write("Ace");
                            break;
                        case 2:
                            Console.Write("2");
                            break;
                        case 3:
                            Console.Write("3");
                            break;
                        case 4:
                            Console.Write("4");
                            break;
                        case 5:
                            Console.Write("5");
                            break;
                        case 6:
                            Console.Write("6");
                            break;
                        case 7:
                            Console.Write("7");
                            break;
                        case 8:
                            Console.Write("8");
                            break;
                        case 9:
                            Console.Write("9");
                            break;
                        case 10:
                            Console.Write("Jack");
                            break;
                        case 11:
                            Console.Write("Queen");
                            break;
                        case 12:
                            Console.Write("King");
                            break;
                    }

                    switch (j)
                    {
                        case 1:
                            Console.WriteLine(" Spades");
                            break;
                        case 2:
                            Console.WriteLine(" Hearts");
                            break;
                        case 3:
                            Console.WriteLine(" Diamonds");
                            break;
                        case 4:
                            Console.WriteLine(" Clubs");
                            break;
                    }
                }
            }
        }
    }
}
