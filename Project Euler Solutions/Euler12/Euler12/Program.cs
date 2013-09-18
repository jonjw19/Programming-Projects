/*
 * Program 12 @ projecteuler.net
 * Find the first triangular number with more than 500 divisors.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler12
{
    class Program
    {
        static void Main(string[] args)
        {
            TriangularNumberGenerator triGen = new TriangularNumberGenerator(500);

            double triNum = triGen.generateNumber();

            Console.WriteLine(triNum);
            Console.ReadLine();


        }
    }
}
