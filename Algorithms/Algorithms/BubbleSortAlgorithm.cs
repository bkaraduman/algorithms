using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Algorithms
{
    public class BubbleSortAlgorithm
    {
        //in place sorting algorithm so i takes contant space
        //it is also stable sort
        //Best case Big Omage n when in sorted order will do n comparisons and 0 swaps!
        //Average case big Theta 0 n^2 for n^2 swaps and comparisons
        //Wors case big O n^2 for n^2 swaps and comparisons

        public static void BubbleSort(double[] unsortedList)
        {
            double temp;

            //we loop through 1 less than the length of the array because we comparing to the number after the current number
            //Thus do not need to go to the last position as there will be no number after it!
            for (int i = 0; i < unsortedList.Length - 1; i++)
            {
                //i is the current position we solve for
                //add i to not go to the last element as that element has already been moved to the right
                for (int j = 0; j < unsortedList.Length - (1 + i); j++)
                {
                    //first to last element [0] > [1] -> [4] > [5]
                    if (unsortedList[j] > unsortedList[j + 1])
                    {
                        temp = unsortedList[j + 1];
                        unsortedList[j + 1] = unsortedList[j];
                        unsortedList[j] = temp;
                    }
                }
            }

            Console.WriteLine("Bubble Sort Algorithm end");

            for (int i = 0; i < unsortedList.Length; i++)
            {
                Console.WriteLine(unsortedList[i]);
            }

            Console.ReadLine();
        }
    }
}
