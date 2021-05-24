using System;
using System.Collections.Generic;
using System.Text;

namespace Lab16_CountriesIO
{
    class CountriesApp
    {
        public static void Display()
        {
            bool repeat = true;
            while (repeat)
            {
            Console.WriteLine("Please choose from the following options:");
            Console.WriteLine("1. Display countries");
            Console.WriteLine("2. Enter a country");
            Console.WriteLine("3. Exit");

            string input = Console.ReadLine();
            

                if (input == "2")
                {
                    CountriesTextFile.WriteList();
                }
                else if (input == "1")
                {
                    CountriesTextFile.ReadList();
                }
                if (input == "3")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
                Console.WriteLine("Would you like to choose again? (y/n)");
                string select = Console.ReadLine().ToLower();

                if (select == "y")
                {
                    repeat = true;
                }
                else if (select == "n")
                {
                    Console.WriteLine("Goodbye!");
                    repeat = false;
                }
                
                
            }
        }
    }
}