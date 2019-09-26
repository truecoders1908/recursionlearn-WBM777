using System;

namespace recursionLearn
{
    class Program
    {

        static void Main(string[] args)                 //A recursion is when you call the method inside of itself forming a type of loop
        {

            Console.WriteLine(Factorial(5));            //printing the factorial of 5 and 10 on lines 11 and 12
            Console.WriteLine(Factorial(10));
            Console.WriteLine(baileyBranch.Baloo(15));              //calling method and printing the result

        }

        static int Factorial(int n)                     //Creating the method Factorial
        {
            if (n == 0)                                //creating if loop where if n equals 0 returns 1
            {
                return 1;
            }

            // recursive solution (as opposed to iterative)
            return n * Factorial(n - 1);                //using a recursive by calling the Method factorial inside of itself

            // e.g.
            // 5! = 5 * 4!
            //  4! = 4 * 3!
            //   3! = 3 * 2!
            //    2! = 2 * 1!
            //     1! = 1 * 0!
            //      0! = 1 (because math)
        }
        
    }
}
