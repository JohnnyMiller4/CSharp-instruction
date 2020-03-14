using System;

namespace BootcampCSharpDay2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C# Day 2!");

            Console.Write("Enter an integer: ");
            int nbr = GetNbr();

            switch (nbr)
            {
                case 1:
                    Console.WriteLine("1 entered.");
                    break;
                case 2:
                    Console.WriteLine("2 entered.");
                    break;
                case 3:
                    Console.WriteLine("3 entered.");
                    break;
                case 4:
                    Console.WriteLine("4 entered.");
                    break;
                default:
                    Console.WriteLine("Other than 1, 2, 3, or 4");
                    break;

            }

            Console.WriteLine("for loop w/ index...");

            for (int i = 0; i < nbr; i++)
            {
                Console.WriteLine(i);
            }

            printThreeNumbers(5, 23, 47);
            printThreeNumbers();
            printThreeNumbers(5, 10);
            //pass n1 and n3, but not n2
            printThreeNumbers(5, n3: 15);
            printThreeNumbers(5, n3: 15, n2: 50);

            Console.Write("Goodbye!");
        }

        //methods and exception handling
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

        private static void printThreeNumbers(int n1 = 1, int n2 = 2, int n3 = 3)
        {
            Console.WriteLine("3 nbrs : " + n1 + ", " + n2 + ", " + n3);
        }
        //overloading
        //private static void printThreeNumbers (int n1, int n2)
        //{
        //    Console.WriteLine("3 nbrs : " + n1 + ", " + n2);
        //}
    }
}
