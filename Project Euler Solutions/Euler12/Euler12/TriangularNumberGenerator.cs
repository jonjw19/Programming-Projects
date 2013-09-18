using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler12
{
    class TriangularNumberGenerator
    {
        public double numDivisors { get; set; }


        public TriangularNumberGenerator(double numOfDivisors)
        {
            numDivisors = numOfDivisors;
        }
/****************************************************************************************************************************
* This code generates a triganular number then passes it to have its divisors counted
* **************************************************************************************************************************/
        public double generateNumber()
        {
            double triNum = 0;
            int divsFound = 0;

            if (numDivisors == 0)
                return 0;

            for (int i = 1; divsFound <= numDivisors; i++)
            {
                triNum = (i * (i + 1)) / 2;

                divsFound = findDivisors(triNum);
                {
                    if (divsFound >= numDivisors)
                    {
                        Console.WriteLine(triNum + "     " + divsFound);
                        return triNum;
                    }
                    else
                    {
                        Console.WriteLine(triNum + "     " + divsFound);
                        divsFound = 0;
                    }
                }
            }

            return triNum;
        }

/**************************************************************************************************************************
* This function finds the divisors of a triangular number by storing each factor and its dual inside
 * a list, to make it faster, after numbers are bigger than 100000 I begin cutting off numbers with low amounts
 * of divisors by dividing the number by a thousand, adding 1, and checking it against the current factor
 * the logic being that the triangular numbers have all their factors stored by the time they have reached their size/ 1000.
 * 
 * This can actually be brought up to 10,000 and still receive a faster correct answer, but that would become a liability
 * at lower divisor amounts.
**************************************************************************************************************************/
        public int findDivisors(double triNum)
        {
            int divsFound = 0;
            List<double> divisors = new List<double>();
            
            for (int j = 1; divsFound < 501 && j <= triNum; j++)
            {

                if (triNum > 100000 && j > ((triNum/1000)+1))
                {
                 
                    return divsFound;
                }

                else if (triNum % j == 0 && divisors.Contains(j) == false)
                {
                    divisors.Add(j);
                    
                    if (triNum / j != j && divisors.Contains(triNum / j) == false)
                        divisors.Add(triNum / j);
                    divsFound = divisors.Count;

                }

            }
            return divsFound;

        }
/***************************************************************************************************************************/

    }
}

