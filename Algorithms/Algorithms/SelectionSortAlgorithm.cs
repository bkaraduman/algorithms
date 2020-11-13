using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Algorithms
{
    public class SelectionSortAlgorithm
    {
        //Selection sort is an in place sorting algorithm with a time complexity of Big O of n^2
        //and a space complexity of Big O of 1 aka constant space
        //Swap the smallest element with the first number(search the entire list before swap). Then move pointer to the
        //Second element and swap the next smallest number in the list with the second element.
        public static void SelectionSort(double[] unsortedList)
        {
            int minIndex = 0; //current index of the current minimum we are looking for
            double minimumValueFound = 0; //temporary variable for swapping the value of the current min index

            //MainIndex is the pointer for each lowest element we need to find
            for (int MainIndex = 0; MainIndex < unsortedList.Length; MainIndex++)
            {
                //MinIndex is now the current spot in the main list
                minIndex = MainIndex;

                //remaining goes threw the remainder of the list finding the index of the next lowest value
                for (int RemainingIndex = MainIndex + 1; RemainingIndex < unsortedList.Length; RemainingIndex++)
                {
                    //if the remaining element is less than the minindex we move the index to that spot.
                    //will swap values after going through the entire list
                    if (unsortedList[RemainingIndex] < unsortedList[minIndex])
                    {
                        //update minimum amount index!
                        minIndex = RemainingIndex;
                    }
                }

                minimumValueFound = unsortedList[minIndex];
                unsortedList[minIndex] = unsortedList[MainIndex];
                unsortedList[MainIndex] = minimumValueFound;
            }


            Console.WriteLine("Selection Sort End");

            for (int i = 0; i < unsortedList.Length; i++)
            {
                Console.WriteLine(unsortedList[i]);
            }

            Console.ReadLine();
        }
    }
}
