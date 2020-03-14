using System;

namespace BootcampCSharpDay1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Day One!");

            int a = 5;
            int b = 10;
            int sum = a + b;

            string choice = "y";

            //type "while" and then tap 'tab' twice
            while (choice.Equals("y")) {
                Console.WriteLine("In a while loop...");
                Console.Write("Choice? (y/n): ");
                choice = Console.ReadLine();
                Console.WriteLine("choice = " + choice);
            }

            Console.WriteLine(sum);

            if (sum > 10)
            {
                Console.WriteLine("Sum greater than 10.");
            }
            else
            {
                Console.Write("Sum less than or equal to 10.");
            }

            Console.Write("Enter a number: ");
            String nbrStr = Console.ReadLine();
            int nbr = Convert.ToInt32(nbrStr);
            Console.WriteLine("nbr = " + nbr);

            double d1 = 4.5;
            double d2 = 5.7;
            int sum2 = (int) (d1 + d2);
            double sum3 = d1 + d2;

            Console.WriteLine(sum2);
            Console.WriteLine(sum3);

            Random random = new Random();

            int r1 = random.Next(5, 20); //random.Next(min, max);
            Console.WriteLine("r1 = " + r1);

            int r2 = random.Next(10); //random.Next(max);
            Console.WriteLine("r2 = " + r2);

            while (r2 != 10)
            {
                r2 = random.Next(10);
                r2++;
                Console.WriteLine(r2);
            }

            double d3 = 75.8834222;
            Console.WriteLine("d3 rounded = " + Math.Round(d3));
            Console.WriteLine("d3 rounded to two digits = " + Math.Round(d3, 2));

            double price = 15.99;
            double pct = .03467;

            Console.WriteLine("price formatted: " + price.ToString("C2"));
            Console.WriteLine("pct formatted: " + pct.ToString("P3"));
            Console.WriteLine("Bye!");
        }
    }
}
