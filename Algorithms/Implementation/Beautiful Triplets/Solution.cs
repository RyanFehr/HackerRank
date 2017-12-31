/*
    Problem: https://www.hackerrank.com/challenges/beautiful-triplets/problem
    C# Language Version: 7.0
    .Net Framework Version: 4.7
    Tool Version : Visual Studio Community 2017
    Thoughts :
    1. Create a hash set out of the input array. Let's call it hs.
    2. Let the beautiful difference be d.
    3. Let there be a counter to keep track of beautiful triplets. Let's call it c.
    4. Start iterating elements of hs in a loop:
       4.1 Let the current element being iterated is n.
       4.2 For n, check if hs also contains n+d and n+2d. If true then increase c by 1.
       4.3 Repeat steps 4.1 to 4.2 untill all elements in hs are iterated.
    5. print the value of c.

    Time Complexity:  O(n)
    Space Complexity: O(n) //An additional hash set has been created to keep all the input elements in a hashmap kind of
                             structure for amortized O(1) read access.
*/

using System;
using System.Collections.Generic;

class Solution
{
    static int BeautifulTriplets(int d, int[] arr)
    {
        var count = 0;
        var set = new HashSet<int>(arr);

        foreach (var item in set)
            if (set.Contains(item + d) && set.Contains(item + 2 * d))
                count++;

        return count;
    }

    static void Main(String[] args)
    {
        var tokens_n = Console.ReadLine().Split(' ');
        //No need to capture the size of array. I use array's length property instead.
        var d = int.Parse(tokens_n[1]);
        var arr_temp = Console.ReadLine().Split(' ');
        var arr = Array.ConvertAll(arr_temp, int.Parse);
        int result = BeautifulTriplets(d, arr);
        Console.WriteLine(result);
    }
}
