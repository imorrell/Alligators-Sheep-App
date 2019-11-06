using System;
using System.Collections.Generic;
using System.Text;

namespace Lab14AlligatorsAndSheeps
{
    class CountTestApp
    {
        public static void CountObjects()
        {
            //prompt the user to enter names and counts for the sheeps
            string sheepOneName = Validator.GetUserInputTwo("Enter name for sheep one\n");

            string sheepTwoName = Validator.GetUserInputTwo("Enter name for sheep two\n");

            int alligatorCount = Validator.ParseString("How many alligators\n");

            int sheepCount = Validator.ParseString("How many sheep\n");

            Alligators gators = new Alligators();

            Console.WriteLine("Counting Alligators\n");
            //call the CountUtil Count methed to print the number of alliators
            CountUtil.Count(gators, alligatorCount);

            //create sheep object
            Sheep sheepOne = new Sheep();

            //set sheep name
            sheepOne.Name = sheepOneName;

            Console.WriteLine("Counting Sheep\n");
            //call the CountUtil method to print out the sheep
            CountUtil.Count(sheepOne, sheepCount);

            //clone sheep one
            Sheep sheepTwo = (Sheep)sheepOne.Clone();

            //set sheepTwos name
            sheepTwo.Name = sheepTwoName;

            //call the CountUtil method to print out sheep two
            CountUtil.Count(sheepTwo, 3);

            //count sheepOne again
            CountUtil.Count(sheepOne, 1);


        }

    }
}
