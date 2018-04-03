/*
         Problem: https://www.hackerrank.com/challenges/icecream-parlor/problem
         C# Language Version: 7.0
         .Net Framework Version: 4.7
         Tool Version : Visual Studio Community 2017
         Thoughts :
         I didn't sort the input. Instead I created a look up of the input array. e.g. for the input test case # 1

         2 2 4 3

         I created a look-up data structure as shown below for each value in the array and the indexes of array where it was found:

         2 - 0,1
         4 - 2
         3 - 3

         Now it was straight forward. Let total money be m

         - Start iterating the original array
         - Let current icecream price be x
         - Other icecream price will be m-x
         - Search (m-x) entry in the look-up
         - If (m-x) is found in the look-up then take out its index from look-up value and produce the final answer.
        
        Note: A special handling while searching the look-up data structure is required as two icecreams can exist who have same price.

         Time Complexity:  O(n) //there are no nested for loops.
         Space Complexity: O(n) //an extra look-up is required
                
           
        */

using System;
using System.Collections.Generic;
using System.Linq;
class Solution
{
    static int[] IcecreamParlor(int totalMoney, int[] icecreamPrices)
    {
        var boughtIcreamIndexes = new int[2];
        var lookUp = icecreamPrices.Select((element, index) => new { element, index }).ToLookup(x => x.element, x => x.index);

        for (var i = 0; i < icecreamPrices.Length; i++)
        {
            if (icecreamPrices[i] < totalMoney)
            {
                var otherIceCreamPrice = totalMoney - icecreamPrices[i];
                if (icecreamPrices[i] == otherIceCreamPrice)
                {
                    //check whether two flavors have got same price
                    if (lookUp.Contains(otherIceCreamPrice))
                    {
                        //there should be two icecream flavors of same price to be able to proceed
                        var samePricedIcreamFlavors = lookUp[otherIceCreamPrice];
                        var indexOfOtherIcecream = -1;
                        if (samePricedIcreamFlavors.Count() > 1)
                        {
                            indexOfOtherIcecream = samePricedIcreamFlavors.Where(x => x != i).Single();
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
                    }
                }
                else
                {
                    if (lookUp.Contains(otherIceCreamPrice))
                    {
                        var indexOfOtherIcecream = lookUp[otherIceCreamPrice].First();// hashMap[otherIceCreamPrice];
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
