/*
         Problem: https://www.hackerrank.com/challenges/utopian-tree/problem
         C# Language Version: 6.0
         .Net Framework Version: 4.5.2
         Thoughts :

         1. Start processing each input test case one by one.
         2. Let number of growth cycles in current test case be N.
         3. Set initial height H of sapling to 1.
         4. Set a boolean isSpring to true. It represents that in any year, first we hit spring season.
         5. Start a loop which runs N times. During each iteration in the loop :
            - If isSpring is true (spring season) then set H to H * 2 and isSpring to false.
            - If isSpring is false (summer season) then set H to H + 1 and isSpring to true.
         6. Print H.
         7. Repeat step 2 through 6 for each test case.

         Time Complexity:  O(n)
         Space Complexity: O(1)
                
        */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        var t = int.Parse(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                var numberOfCycles = int.Parse(Console.ReadLine());
                var finalHeightOfSapling = 1;
                bool isSpring = true;
                while (numberOfCycles > 0)
                {
                    if (isSpring)
                    {
                        finalHeightOfSapling *= 2;
                        isSpring = false;
                    }
                    else
                    {
                        finalHeightOfSapling++;
                        isSpring = true;
                    }
                    numberOfCycles--;
                }
                Console.WriteLine(finalHeightOfSapling);
            }
    }
}
