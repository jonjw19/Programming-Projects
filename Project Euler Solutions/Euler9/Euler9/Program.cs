/*
 * PROBLEM 9 @ projecteuler.net
 * There exists exactly one Pythagorean triplet for which a + b + c = 1000.
 * Find the product abc
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler9
{
    class Program
    {
        static void Main(string[] args)
        {

            // This loop is done in reverse to implicity cause
            // a<b<c. The end of the loop checks both conditions
            // stated by the problem
            for (int k = 0; k <= 1000; k++)
            {
                for (int j = 0; j < k; j++)
                {
                    for (int i = 0; i < j; i++)
                    {
                        if (Math.Pow(i, 2) + Math.Pow(j, 2) == Math.Pow(k, 2) && i + j + k == 1000)
                        {
                            Console.WriteLine(i * j * k);
                            Console.ReadLine();
                        }
                    }
                }
            }
        }
    }
}
