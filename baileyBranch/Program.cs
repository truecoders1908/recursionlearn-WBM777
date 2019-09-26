using System;

namespace baileyBranch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Baloo(50));              //calling method and printing the result
        }
        static int Baloo(int raj)                      //this is a simple method that will add every number from the first number down to zero
        {

            return raj + Baloo(raj - 1);               //returning raj plus the method Baloo with raj minus 1 in the paremeters

        }
    }
}
