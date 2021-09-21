// ISM 4300 Program #3 - Created by Brian Best
// This program gives the user a table based on kilometers traveled changed to miles.
// Date 9/21/2021
using System;
namespace Lead_Foot_Auto_Rental
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask the user for a speed between 10 and 25 kilometers
            Console.WriteLine("Enter a value between 10 and 25 to view the table.");

            // Use catch block system in order to keep user from entering values that do not work
            try
            {

                // Gather data from user input
                string input = Console.ReadLine();

                // This varibale will be used to perfrom the iterative statments and is parsed as an integer
                int kilometers_per_hour = int.Parse(input);

                // Use a if/else statement to test the value of the input
                // Integer is between 10 and 25 kilometers
                if ((kilometers_per_hour > 9) && (kilometers_per_hour <= 25))
                {
                    Console.WriteLine("Speed Conversion Table: ");
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine("Kilometers:" + "     " + "Miles:");

                    // For loop
                    for (int km = 0; km <= 200; km+=int.Parse(input))
                    {
                        Console.WriteLine(km.ToString("n2") + "            " + (km * 0.621371).ToString("n2"));
                    }
                    Console.WriteLine("Press any key to exit the program.");

                    //Pause program to allow key to be pressed to exit
                    Console.ReadKey(true);
                }

                // If the user does not enter a value between 10 and 25
                else
                {
                    Console.WriteLine("In order for the table to start, please enter a value between 10 and 25.");
                    Console.WriteLine("Press any key to exit the program and try again.");
                    Console.ReadKey(true);

                }
            } // End of try
            catch
            {
                Console.WriteLine("Please enter a integer value between 10 and 25 and retry the program.");
                Console.WriteLine("Press any key to exit the program.");
                Console.ReadKey(true);
            }
        }
    }
}
