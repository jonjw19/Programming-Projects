/*
 * PROBLEM 10 @ projecteuler.net
 * Find the sum of all the primes below two million.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Here I initialize my list and add the first few primes
            // This will end up speeding up the trial division process.
            double sumOfPrimes = 0;
            List<double> primes = new List<double>();
            primes.Add(2);
            primes.Add(3);
            primes.Add(5);
            primes.Add(7);
            primes.Add(11);
            primes.Add(13);


            // This loop checks against my preloaded primes so
            // it can use a check against 1/13th of the current i
            // eliminating a lot more options at once then in problem 7
            for (int i = 17; i <= 2000000; i += 2)
            {
                if (i % 2 != 0 && i % 3 != 0 && i % 5 != 0 && i % 7 != 0 && i % 11 != 0 && i % 13 != 0)
                {
                    for (int j = 5; j < primes.Count(); j++)
                    {

                        if (primes[j] > (i / 13))
                        {
                            primes.Add(i);
                            break;
                        }
                        if (i % primes[j] == 0)
                        {
                            break;
                        }
                        else if (j == primes.Count() - 1)
                        {
                            primes.Add(i);
                            break;
                        }
                    }
                }
            }


            // Adding up my primes
            for (int i = 0; i < primes.Count; i++)
                sumOfPrimes += primes[i];

            // And... Victory, but a very slow one
            // I'm trying to do these without looking up
            // tried and true algo's from the internet
            // so if I were to redo this I would use 
            // a sieve algo of some kind.
            Console.WriteLine(sumOfPrimes);
            Console.ReadLine();


        }
    }
}
