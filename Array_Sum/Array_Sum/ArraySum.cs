using System;
using System.Collections.Generic;
using System.Linq;

namespace AutoTEAM
{
    class ArraySum
    {
        static void Main()
        {
            FilterArrayFindSum();

        }

        private static void FilterArrayFindSum()
        {
            List<int> newList = new List<int>();
            Console.WriteLine("Generating array...");
            int[] myArray = Enumerable.Range(1, 20).ToArray();

            Console.WriteLine("Searching for valid numbers...");
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] % 3 == 0 && myArray[i] % 5 != 0)
                {
                    Console.WriteLine("Number divided by 3 and not divided by 5 found");
                    int x = myArray[i];
                    Console.WriteLine(x);
                    newList.Add(x);
                }
            }
            Console.WriteLine("Sum of numbers:");
            Console.WriteLine(newList.Sum());
        }

    }

}