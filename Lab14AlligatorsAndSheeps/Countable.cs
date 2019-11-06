using System;
using System.Collections.Generic;
using System.Text;

namespace Lab14AlligatorsAndSheeps
{
    interface ICountable
    {

        void IncrementCount();
        void ResetCount();
        int GetCount();
        string GetCountString();

    }
}
