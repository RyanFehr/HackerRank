/*
         Problem: https://www.hackerrank.com/challenges/service-lane/problem
         C# Language Version: 6.0
         .Net Framework Version: 4.7
         Tool Version : Visual Studio Community 2017
         Thoughts : Below algorithm is pertaining to one test case
         1. For a given test case let service lane entry index be ei.
         2. Let service lane exit index be xi.
         3. Initialize a minimum width tracker. Let's call it minW and set it to 3 which is the width of a truck.
         4. Let there be an array warr which contains the width of all the portions of service lane.
         5. Start iterating wrr in a loop starting from ei index until xi index:
            5.1 If current service lane width being iterated is less than minW then set minW to the value of current service lane width
            5.2 if minW is now already at 1 (widht of a bike) then quit the loop else continue.
            5.3 Repeat the steps from 5.1 through 5.2 from all the elements as per index constraints.
         6. Print the value of mindW on console.

         Time Complexity:  O(n) //in worst case I might have to traverse the entire service lane array.
         Space Complexity: O(n) //we are storing the width of all the portions of service lane in an array.
         
        */
using System;

class Solution
{
    static void ServiceLane(int[] serviceLaneWidths, int[][] cases)
    {
        for (int i = 0; i < cases.Length; i++)
        {
            var entryIndex = cases[i][0];
            var exitIndex = cases[i][1];

            var minWidth = 3;//for truck
            for (int j = entryIndex; j <= exitIndex; j++)
            {
                if (serviceLaneWidths[j] < minWidth)
                    minWidth = serviceLaneWidths[j];

                //a portion of service lane is allowing only bikes so no more traversal is required.
                if (minWidth == 1)
                    break;
            }
            Console.WriteLine(minWidth);
        }
    }
    static void Main(String[] args)
    {
        var tokens_n = Console.ReadLine().Split(' ');
        var t = int.Parse(tokens_n[1]);
        var width_temp = Console.ReadLine().Split(' ');
        var width = Array.ConvertAll(width_temp, Int32.Parse);
        var cases = new int[t][];
        for (var cases_i = 0; cases_i < t; cases_i++)
        {
            var cases_temp = Console.ReadLine().Split(' ');
            cases[cases_i] = Array.ConvertAll(cases_temp, Int32.Parse);
        }
        ServiceLane(width, cases);
    }
}
