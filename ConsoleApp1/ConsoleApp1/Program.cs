using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("URL Encoder");

            do
            {
                Console.Write("\nProject name: ");
                string projectName = GetUserInput();
                Console.Write("Activity name: ");
                string activityName = GetUserInput();

                Console.WriteLine(CreateURL(projectName, activityName));

                Console.Write("Would you like to do another? (y/n): ");
            } while (Console.ReadLine().ToLower().Equals("y"));
        }

        static string CreateURL(string projectName, string activityName)
        {
            // create the URL string and return it
        }

        static string GetUserInput()
        {
            // get valid input from the user
            // disallow strings with control characters
            // IsValid() below is used to check if input is valid
        }

        static bool IsValid(string input)
        {
            // check if the string is valid and does not
            // contain control characters
            // if valid, return true
            // if not valid, return false
        }

        static string Encode(string value)
        {
            // return an encoded version of the 
            // string provided in value
        }
    }
}
