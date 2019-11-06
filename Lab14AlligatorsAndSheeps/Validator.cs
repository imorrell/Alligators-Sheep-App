using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Lab14AlligatorsAndSheeps
{
    class Validator
    {
        public static string GetUserInputTwo(string message)
        {
            string input;

            Console.WriteLine(message);

            input = Console.ReadLine();

            Console.WriteLine();

            //check user input for empty or digits only
            if (input == "")
            {
                Console.WriteLine("Entry blank! Please enter a name! \n");
                return GetUserInput(message);
            }
            else if (Regex.IsMatch(input, @"^[0-9]*$"))
            {
                Console.WriteLine("Wrong input! Input characters only \n");
                return GetUserInput(message);
            }
            else
            {
                return input;
            }

        }

        public static int ParseString(string message)
        {
            try
            {
                string input = GetUserInput(message);
                int number = int.Parse(input);
                return number;
            }
            catch (FormatException)
            {
                Console.WriteLine("Bad input. We need a number \n");
                return ParseString(message);
            }

        }

        public static string GetUserInput(string message)
        {
            string input;

            Console.WriteLine(message);

            input = Console.ReadLine();

            return input;
        }
    }

}
