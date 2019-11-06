using System;
using System.Collections.Generic;
using System.Text;

namespace Lab14AlligatorsAndSheeps
{
    class Sheep : ICountable, ICloneable
    {
        public int count = 0;
        private string name;

        public string Name 
        { get => name; 
          set => name = value; }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public int GetCount()
        {
            return count;
        }

        public string GetCountString()
        {
            return $"{count} " + $"{Name}" ;
        }

        public void IncrementCount()
        {
            count++;
        }

        public void ResetCount()
        {
            count = 0;
        }
    }
}
