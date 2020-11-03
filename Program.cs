using System;
using System.Linq;

namespace InsertionSort
{
    class ProgramTester
    {
        private static void Main(string[] args)
        {
            try
            {
                //configure your log e.g. DEBUG

                // LOG.debug("This is debug only"); -- logs when log level is DEBUG
                // LOG.info("This is info only"); ---- logs when log level is info

                // LOG.ERROR("This is ERROR only"); ---- logs when log level is info

                Console.WriteLine("Inside Main ");
                // LOG.info("This is info only"); ---- logs when log level is info

                int[] originalList = new int[] { 23, 4, 16, 45, 2 };

                // sorted with one iteration
                int[] expectedAfterOneSortIteration = new int[] { 4, 23, 16, 45, 2 };

                // sorted list after two iterations
                int[] expectedAfterTwoSortIterations = new int[] { 4, 16, 23, 45, 2 };

                // sorted list after three iterations
                int[] expectedAfterThreeSortIterations = new int[] { 4, 16, 23, 45, 2 };

                // sorted list after full sort
                int[] expectedListFullSort = new int[] {2, 4, 16, 23, 45 };

                Console.WriteLine("Calling Sort from Main... ");

                int ITERATIONS_1 = 1;
                int ITERATIONS_2 = 2;
                int ITERATIONS_3 = 3;

                MyInsertionSort sort = new MyInsertionSort();

                Console.WriteLine("Sorting with only one iteration");
                Console.WriteLine("--------------------------------");
                int[] ActualListSorted_One_Iteration = sort.Sort(originalList, ITERATIONS_1);
                Console.WriteLine(string.Join(',', ActualListSorted_One_Iteration));
                Console.WriteLine("Sorted list and expected list are same order: " + ActualListSorted_One_Iteration.SequenceEqual(expectedAfterOneSortIteration));
                Console.WriteLine("");

                Console.WriteLine("Sorting with only two iterations");                             
                Console.WriteLine("--------------------------------");
                int[] ActualListSorted_Two_Iteration = sort.Sort(originalList, ITERATIONS_2);
                Console.WriteLine("Sorted List: " + string.Join(',', ActualListSorted_Two_Iteration));
                Console.WriteLine("Sorted list and expected list are same order: " + ActualListSorted_Two_Iteration.SequenceEqual(expectedAfterTwoSortIterations));
                Console.WriteLine("");

                Console.WriteLine("Sorting with three iterations");
                Console.WriteLine("--------------------------------");
                int[] ActualListSorted_Three_Iteration = sort.Sort(originalList, ITERATIONS_3);
                Console.WriteLine("Sorted List: " + string.Join(',', ActualListSorted_Three_Iteration));
                Console.WriteLine("Sorted list and expected list are same order: " + ActualListSorted_Three_Iteration.SequenceEqual(expectedAfterThreeSortIterations));
                Console.WriteLine("");

                Console.WriteLine("Sorting entire list");
                Console.WriteLine("--------------------------------");
                int[] ActualListSorted_Full_Sort = sort.Sort(originalList);
                Console.WriteLine("Sorted List: " + string.Join(',', ActualListSorted_Full_Sort));
                Console.WriteLine("Sorted list and expected list are same order: " + ActualListSorted_Full_Sort.SequenceEqual(expectedListFullSort));
                Console.WriteLine("");

                Console.ReadKey();
            }
            catch(Exception e)
            {
                throw e;
                // log.Error(e);
            }
            
        }
    }
}
