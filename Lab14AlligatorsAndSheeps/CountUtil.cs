using System;
using System.Collections.Generic;
using System.Text;

namespace Lab14AlligatorsAndSheeps
{
    class CountUtil
    {

        public static void Count(ICountable c, int maxCount)
        {

            //use while to count the number of Countable objects
            while (maxCount != 0)
            {
                c.IncrementCount();
                Console.WriteLine(c.GetCountString());
                maxCount--;
            }
            Console.WriteLine();
            //reset the count 
            c.ResetCount();
        }


    }
}
