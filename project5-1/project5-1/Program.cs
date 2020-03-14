using System;

namespace project5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string Choice = "y";

            Console.WriteLine("Welcome to the Letter Grade Converter");

            Console.WriteLine("\nRoll the dice? (y/n): ");
            Choice = Console.ReadLine();

            while (Choice.Equals("y"))
            {
                int Die1 = DiceRoll(1, 6);
                int Die2 = DiceRoll(1, 6);
                int Total = Die1 + Die2;

                Console.WriteLine("DiceNum1: " + Die1);
                Console.WriteLine("DiceNum2: " + Die2);

                if (((int)Die1 == 1) && ((int)Die2 == 1))
                {
                    Console.WriteLine("Snake eyes!");
                }
                else if (((int)Die1 == 6) && ((int)Die2 == 6))
                {
                    Console.WriteLine("Boxcars!");
                }

                Console.Write("Roll again? (y/n): ");
                Choice = Console.ReadLine();

            }
        }

        private static int DiceRoll(int min, int max)
        {
            Random random = new Random();


            return random.Next(min, max);
        }

    }
}
