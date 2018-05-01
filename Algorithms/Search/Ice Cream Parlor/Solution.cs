/*
         Problem: https://www.hackerrank.com/challenges/icecream-parlor/problem
         C# Language Version: 7.0
         .Net Framework Version: 4.7
         Tool Version : Visual Studio Community 2017
         Thoughts :

         Instead I created a dictionary look up (element,index) of the input array as I iterated through the elements. e.g. for the input test case # 0

         4 (Sum to be found)
         5 (number of input elements)
         1 4 5 3 2

         I created a look-up data structure as shown below for each value in the array during iteration:

         1 - 0
         4 - <ignored as a pair will not be possible in this case>
         5 - <ignored as a pair will not be possible in this case>
         3 - [Solution found at this element. Break further iteration]

         Case # 1 has got duplicate elements. So how do you insert the duplicate values in dictionary?

         4 (Sum to be found)
         4 (number of input elements)
         2 2 4 3
        
         Duplicate value will have two cases:
         - Either it will be part of the solution pair. So, you will get solution the moment you reach to the duplicate
            element. So you will not need to insert it any way.
         - If it is not part of the solution pair then you can simply ignore it.

         Time Complexity:  O(n) //there are no nested for loops.
         Space Complexity: O(n) //an extra look-up dictionary storage is required
                
           
        */

using System;
using System.Collections.Generic;
using System.Linq;
class Solution
{

    static int[] IcecreamParlor(int totalMoney, int[] icecreamPrices)
    {
        var boughtIcreamIndexes = new int[2];
        var lookup = new Dictionary<int, int>();
        for (var i = 0; i < icecreamPrices.Length; i++)
        {
            if (icecreamPrices[i] < totalMoney)
            {
                var otherIceCreamPrice = totalMoney - icecreamPrices[i];
                if (lookup.ContainsKey(otherIceCreamPrice))
                {
                    //solution found
                    var indexOfOtherIcecream = lookup[otherIceCreamPrice];
                    if (indexOfOtherIcecream < i)
                    {
                        boughtIcreamIndexes[0] = indexOfOtherIcecream + 1;
                        boughtIcreamIndexes[1] = i + 1;
                    }
                    else
                    {
                        boughtIcreamIndexes[0] = i + 1;
                        boughtIcreamIndexes[1] = indexOfOtherIcecream + 1;
                    }
                    break;
                }
                else
                {
                    if (!lookup.ContainsKey(icecreamPrices[i]))
                        lookup.Add(icecreamPrices[i], i);
                }
            }
        }
        return boughtIcreamIndexes;
    }

    static void Main(String[] args)
    {
        var t = int.Parse(Console.ReadLine());
        for (int a0 = 0; a0 < t; a0++)
        {
            var m = Convert.ToInt32(Console.ReadLine());
            //No need to capture the size of array. We can use array's length property instead.
            Console.ReadLine();
            var arr_temp = Console.ReadLine().Split(' ');
            var arr = Array.ConvertAll(arr_temp, int.Parse);

            var result = IcecreamParlor(m, arr);
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
