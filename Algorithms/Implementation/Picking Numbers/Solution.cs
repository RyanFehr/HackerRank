/*
         Problem: https://www.hackerrank.com/challenges/picking-numbers/problem
         C# Language Version: 6.0
         .Net Framework Version: 4.5.2
         Thoughts :

        1. Sort the input array containing n integers in ascending order.
        2. Initialize a variable maxSetCount to 0.
        3. Start processing the elements in the sorted array using a loop:
            3.1 Let the index of current element be i.
            3.2 If the current element is equal to its previous element so it is already processed. skip it.
            3.3 If the current element is not equal to its previous element then process it with below steps.
                3.3.1 Start iterating the sorted array from index i+1 of the sorted array in a new loop.
                3.3.2 Initialize a variable currentSetCount = 1
                3.3.3 Increment currentSetCount by 1 if absolute difference of current element in outer loop and current 
                        element in inner loop is less than or equal to 1.
                3.3.4 Quit the inner loop if absolute difference of current element in outer loop and current 
                        element in inner loop is greater than 1.
                3.3.5 Set maxSetCount to currentSetCount if currentSetCount is greater than maxSetCount.
            3.4 Process all elements of the sorted array using steps 2.1 through 2.3.
        4. Print maxSetCount on console.
                
         
         Time Complexity:  O(n)
         Space Complexity: O(n) //we require an addtional array to keep all the input numbers in sorted order.
        */ 

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
            Console.ReadLine();
            var a_temp = Console.ReadLine().Split(' ');
            var a = Array.ConvertAll(a_temp, Int32.Parse);
            var maxCount = 0;
            var sortedList = a.OrderBy(x => x).ToList();

            for (int i = 0; i < sortedList.Count; i++)
            {
                var currentCount = 1;
                if (i > 0)
                    if (sortedList[i] == sortedList[i-1])
                        continue;

                for (int j = i+1; j < sortedList.Count; j++)
                {
                    if (Math.Abs(sortedList[j]-sortedList[i]) <=1)
                        currentCount++;
                    else
                        break;
                }

                if (currentCount > maxCount)
                    maxCount = currentCount;
            }
            Console.WriteLine(maxCount);
    }
}
