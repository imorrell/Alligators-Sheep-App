using System;
using System.Collections.Generic;
using System.Text;

namespace Lab14AlligatorsAndSheeps
{
    class Alligators : ICountable
    {
        public int counter = 0;

        public int GetCount()
        {
            return counter;
        }

        public string GetCountString()
        {
            return $"{counter}" + " alligator";
        }

        public void IncrementCount()
        {
           counter++;
        }

        public void ResetCount()
        {
            counter = 0;
        }
    }
}
