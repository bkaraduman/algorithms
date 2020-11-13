using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Algorithms
{
    public class InsertionSortAlgorithm
    {
        //like sorting cards
        //start at position 2(index 1). Go through the array selecting each position
        //and then move that number backwards in the array until its in the current correct spot
        //Big O of n^2 aka quadratic time complexity and constant space complexity because it is in place
        //it is also stable sorting algorithm
        public static void InsertionSort(double[] unsortedList)
        {
            int i = 1;//index of element to be moved back
            int j = i; //index of element we are trying to swap to
            double temp = 0; //temp variable used to swap

            //go from 1 to the end of the list
            while (i < unsortedList.Length)
            {
                j = i;//set the index of current item we are looking at
                      //as long as there is a number larger to the left and we havent gone through
                      //each element then swap our current element one position backwards

                while (j > 0 && unsortedList[j - 1] > unsortedList[j])
                {
                    //next 3 lines swaps j and j-1
                    temp = unsortedList[j];
                    unsortedList[j] = unsortedList[j - 1];
                    unsortedList[j - 1] = temp;
                    j--; //decrement to compare to the next element to the left
                }
                i++;
            }


            Console.WriteLine("Insertion Sort End");

            for (int index = 0; index < unsortedList.Length; index++)
            {
                Console.WriteLine(unsortedList[index]);
            }

            Console.ReadLine();
        }
    }
}
