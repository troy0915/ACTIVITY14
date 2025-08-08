using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get age input from the user
            Console.Write("Enter your age: ");
            string input = Console.ReadLine();

            // Validate input: check if it is a valid integer
            if (int.TryParse(input, out int age))
            {
                // Classify age
                if (age >= 0 && age <= 12)
                {
                    Console.WriteLine("Child");
                }
                else if (age >= 13 && age <= 19)
                {
                    Console.WriteLine("Teen");
                }
                else if (age >= 20 && age <= 59)
                {
                    Console.WriteLine("Adult");
                }
                else if (age >= 60)
                {
                    Console.WriteLine("Senior");
                }
                else
                {
                    Console.WriteLine("Error: Age cannot be negative.");
                }
            }
            else
            {
                Console.WriteLine("Error: Please enter a valid integer for age.");
            }
        }
    }
}




