/*
    Problem: https://www.hackerrank.com/challenges/cut-the-sticks/problem
    C# Language Version: 6.0
    .Net Framework Version: 4.7
    Tool Version : Visual Studio Community 2017
    Thoughts :
    1. Sort the length of all sticks in descending order. Let the new sorted array be arr.
    2. Let the number of sticks be n.
    3. Run a loop while n > 0
    3.1 print n.
    3.2 Let the smallest stick in the current lot be of length s. set n to arr[n-1].
    3.3 Start iterating from n-1th element in array arr towards the front of the array
        3.3.1 Reduce s from current array element and store the new value back into the array at same position.
        3.3.2 If new value being saved in step 3.3.1 is 0 then reduce n by 1.
        3.3.3 Repeat through steps 3.3.1 to 3.3.2 untill front of array arr is reached.
    3.4 Go to step 3.1 if n is still greater than 0.

    Time Complexity:  O(n log(n)) C# LINQ's sorting uses stable quick sort which is n log (n) in average case.
    Space Complexity: O(n) //we need to create an extra array which keeps all the stick lengths in descending sorted order.
                
*/

using System;
using System.Linq;

class Solution
{
    static void Main(String[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var arr_temp = Console.ReadLine().Split(' ');
        var sticks = Array.ConvertAll(arr_temp, Int32.Parse);
        var sortedSticks = sticks.OrderByDescending(x => x).ToList(); //LINQ sorting uses stable quick sort

        while (n > 0)
        {
            Console.WriteLine(n);
            var smallestStickLength = sortedSticks[n - 1];
            for (int i = n - 1; i >= 0; i--)
            {
                sortedSticks[i] -= smallestStickLength;
                if (sortedSticks[i] == 0)
                    n--;
            }
        }
    }
}
