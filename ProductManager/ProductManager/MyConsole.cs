using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManager
{
    class MyConsole
    {
        public static string GetString(string prompt)
        {
            String s;

            while (true)
            {
                Console.Write(prompt);
                try
                {
                    s = Console.ReadLine();
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error " + e);
                }
            }

            return s;
        }

        public static int GetInt(string prompt)
        {
            int i;

            while (true)
            {
                Console.Write(prompt);
                try
                {
                    i = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error " + e);
                }
            }

            return i;
        }

        public static double GetDouble(string prompt)
        {
            double d;

            while (true)
            {
                Console.Write(prompt);
                try
                {
                    d = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error " + e);
                }
            }
            return d;
        }
    }
}
