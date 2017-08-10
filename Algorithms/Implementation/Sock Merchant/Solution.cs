/*
         Problem: https://www.hackerrank.com/challenges/sock-merchant/problem
         C# Language Version: 6.0
         .Net Framework Version: 4.5.2
         Thoughts :
         1. Take the input array containing colors (number coded) of n socks.
         2. Sort the array in ascending order and store it in a new list. Let's call the sorted list as sortedSocks.
         3. Initialize a counter pairsFound with 0.
         4. Start iterating the sortedSocks elements in a loop. 
            4.1 Let the current list index be i.
            4.2 If ith element in the list is equal to i+1th element in the list then increment pairsFound by 1 
                and also increment loop counter i by 1(Increment in loop counter in this case is an addtional increment
                apart from default loop increment. So in this case loop counter will jump by 2)
            4.3 Continue iterating the loop till n-1th index only. DO NOT iterate the last element of 
                sortedPairs list in the loop.
         5. Print pairsFound.

         

         Time Complexity:  O(nlogn) // LINQ internally uses stable quick sort (nlogn). In addition, we need to iterate the 
                                sorted list one time
         Space Complexity: O(n) //an addtional array/list is required to store the sorted elements.
                
        */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int sockMerchant(int[] ar) {
        var pairsFound = 0;
            var sortedPairs = ar.OrderBy(x => x).ToList();

            for (int i = 0; i < sortedPairs.Count-1; i++)
            {
                if (sortedPairs[i] == sortedPairs[i+1])
                {
                    pairsFound++;
                    i++;
                }
            }
                    return pairsFound;

    }

    static void Main(String[] args) {
            Console.ReadLine();
            var ar_temp = Console.ReadLine().Split(' ');
            var ar = Array.ConvertAll(ar_temp, Int32.Parse);
            var result = sockMerchant(ar);
            Console.WriteLine(result);
    }
}
