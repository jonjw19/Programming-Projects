/*
 * PROBLEM 7 @ projecteuler.net:
 * By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
 * What is the 10 001st prime number?
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> primes = new List<double>();
            primes.Add(2);

            // Because our alogrithm gets its speed from dividing by 2
            // we start our loop at 3 with 2 preloaded in our prime list
            for (int i = 3; primes.Count <= 10000; i++)
            {
                if (i % 2 != 0)
                {
                    // Here each number in the list of primes is tested
                    // against the newest number, if none are successful
                    // the number is prime and is added to the list
                    for (int j = 0; j <= primes.Count - 1; j++)
                    {
                        if (i % primes[j] == 0)
                        {
                            break;
                        }
                        else if (j == primes.Count - 1)
                        {
                            primes.Add(i);
                            break;
                        }
                    }
                }
            }
            // Displaying our victory!
            Console.WriteLine(primes[10000]);
        }
    }
}
