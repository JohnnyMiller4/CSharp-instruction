using System;

namespace project4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Factorial Calculator");
            string Choice = "y";

            while (Choice.Equals("y"))
            {
                int N = 0;
                int A = 1;
                int Fact = 1;
                Console.WriteLine("Enter an integer that's greater than 0 and less than 10:" );
            N = GetNbr();

            while (A <= N)
            {
                Fact *= A;
                A++;
            }

            Console.WriteLine("The factorial of " + N + " is " + Fact + ".");

            Console.Write("Continue? (y/n): ");
            Choice = Console.ReadLine();
            }
        }
        private static int GetNbr()
        {
            int nbr = 0;
            try
            {
                nbr = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalind input.");
                Console.WriteLine(e.ToString());
            }
            return nbr;
        }
    }
}
