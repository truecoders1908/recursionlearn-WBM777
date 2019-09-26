using System;
using System.Collections.Generic;
using System.Text;

namespace recursionLearn
{
    public class baileyBranch
    {
        public static int Baloo(int raj)                      //this is a simple method that will add every number from the first number down to zero
        {
            if (raj == 0)
                return 1;
            return raj + Baloo(raj - 1);               //returning raj plus the method Baloo with raj minus 1 in the paremeters

        }
    }
}
