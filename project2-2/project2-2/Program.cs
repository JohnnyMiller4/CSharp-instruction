using System;

namespace project2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string Choice = "y";
            string StrGrade = "";
            int NumGrade = 0;

            Console.WriteLine("Welcome to the Letter Grade Converter");

            while (Choice.Equals("y"))
            {
                Console.Write("Enter numberical grade: ");
                NumGrade = Convert.ToInt32(Console.ReadLine());

                if (NumGrade > 100 || NumGrade < 0)
                {
                    StrGrade = "Invalid Entry";
                }
                else if (NumGrade >= 87 && NumGrade <= 100)
                {
                    StrGrade = "A";
                }
                else if (NumGrade >= 79 && NumGrade < 87)
                {
                    StrGrade = "B";
                }
                else if (NumGrade >= 67 && NumGrade < 79)
                {
                    StrGrade = "C";
                }
                else if (NumGrade >= 60 && NumGrade < 67)
                {
                    StrGrade = "D";
                }
                else if (NumGrade >= 0 && NumGrade < 60)
                {
                    StrGrade = "F";
                }

                Console.WriteLine("Letter Grade: " + StrGrade);
                Console.Write("Continue? (y/n): ");
                Choice = Console.ReadLine();
            }

            Console.WriteLine("Goodbye!");

        }
    }
}
