/*
 * A reusable class that takes any size 2d array and can find the highest
 * combination of consecutive numbers in either the entire grid, just horizontally
 * just vertically, or either east diagonal or west diagonal.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler11
{
    class gridFind
    {
        public int lengthOfNumString{get; set;}
        public int arrayLength{get; set;}
        public int arrayHeight{get; set;}
        public int[,] grid { get; set; } 

        public gridFind(int[,] g, int numString)
        {
            this.grid = g;
            this.arrayLength = g.GetUpperBound(1);
            this.arrayHeight = g.GetUpperBound(0);
            this.lengthOfNumString = numString;
        }
/*****************************************************************************************************************************
 * This function takes the passed 2 dimensional array and returns the highest vertically
 * placed product of n numbers
 * ***************************************************************************************************************************/
        public double findHighVertical()
        {
            double highVertical = 0,
                   currentVertical= 1;
            
            bool maxDepth = false;

            for (int i = 0; i < arrayHeight; i++)
            {
                if (maxDepth == true)
                    break;

                else if (i == arrayHeight - lengthOfNumString - 1)
                    maxDepth = true;

                for (int j = 0; j < arrayLength; j++)
                {
                    // This loop uses the starting point and gathers n numbers from under it
                    for (int k = 0; k < lengthOfNumString; k++)
                        currentVertical *= grid[(i + k), j];
                    
                    if (currentVertical > highVertical)
                        highVertical = currentVertical;

                    currentVertical = 1;
                }
            }
            return highVertical;
        }

/*****************************************************************************************************************************
 * This function takes the passed 2 dimensional array and returns the highest horizontal
 * placed product of n numbers
 * ***************************************************************************************************************************/
        public double findHighHorz()
        {
            double highHorz= 0,
                   currentHorz = 1;
            bool maxLength = false;

            for (int i = 0; i < arrayHeight; i++)
            {
                for (int j = 0; j < arrayLength; j++)
                {
                    if (maxLength == true)
                        break;
                    else if (j == arrayLength - lengthOfNumString - 1)
                        maxLength = true;

                    for (int k = 0; k < lengthOfNumString; k++)
                        currentHorz *= grid[i, (j + k)];

                    if (currentHorz > highHorz)
                        highHorz = currentHorz;
                    currentHorz = 1;
                }
            }


            return highHorz; 
        }

/*****************************************************************************************************************************
* This function takes the passed 2 dimensional array and returns the highest northwest diagonal
* placed product of n numbers
* ***************************************************************************************************************************/
        public double findHighNW()
        {
            double highNW = 0,
                   currentNW = 1;

            bool maxLength = false;

            for (int i = (lengthOfNumString-1); i < arrayHeight; i++)
            {
                for (int j = (lengthOfNumString-1); j < arrayLength; j++)
                {
                    for (int k = 0; k < lengthOfNumString; k++)
                        currentNW *= grid[(i), (j-k)];

                    if (currentNW > highNW)
                        highNW = currentNW;
                    currentNW = 1;
                }

            }
            return highNW;
        }


/*****************************************************************************************************************************
* This function takes the passed 2 dimensional array and returns the highest northeast diagonal
* placed product of n numbers
****************************************************************************************************************************/
        public double findHighNE()
        {
            double highNE = 0,
                   currentNE = 1;

            bool maxLength = false;

            for (int i = (lengthOfNumString - 1); i < arrayHeight; i++)
            {
                for (int j = 0; j < arrayLength - lengthOfNumString; j++)
                {
                    for (int k = 0; k < lengthOfNumString; k++)
                        currentNE *= grid[(i), (j+k)];

                    if (currentNE > highNE)
                        highNE = currentNE;
                    currentNE = 1;
                }

            }
            return highNE;
        }

/*****************************************************************************************************************************
* This function takes the 4 high products and finds the single highest.
****************************************************************************************************************************/
        public double findHighestProduct()
        {
            double highestVert = findHighVertical(),
                   highestHorz = findHighHorz(),
                   highestNE = findHighNE(),
                   highestNW = findHighNW();

            List<double> highList = new List<double>();
            highList.Add(highestVert);
            highList.Add(highestHorz);
            highList.Add(highestNE);
            highList.Add(highestNW);

            highList.Sort();

            return highList[3];
        }
    
    }
}

