using System;
using System.Collections.Generic;
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
                int[] expectedAfterOneSortIteration = new int[] { 2, 8, 4, 9, 3, 6 };

                // sorted list after two iterations
                int[] expectedAfterTwoSortIterations = new int[] { 2, 4, 8, 9, 3, 6 };

                // sorted list after full sort
                int[] expectedList = new int[] { 2, 3, 4, 6, 8, 9 };

                Console.WriteLine("After Sort");


                Console.WriteLine("Calling Sort from Main.. ");
                int ITERATIONS_TO_RUN = 2;
                int[] ActualListSorted = MyInsertionSort.Sort(originalList, ITERATIONS_TO_RUN);
                Console.WriteLine("Done Sorting. ");

                Console.WriteLine(string.Join(',', ActualListSorted));
                Console.WriteLine("Sorted list  and expected list are same order: " + originalList.SequenceEqual(expectedAfterOneSortIteration));
            }
            catch(Exception e)
            {
                // log.Error(e);
            }
            
        }
    }
}
