using Algorithms.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] unsortedList = { 36, 2, 28, 1, 23, 7, 44 };

            // BubbleSortAlgorithm.BubbleSort(unsortedList);
            
            SelectionSortAlgorithm.SelectionSort(unsortedList);
        }
    }
}
