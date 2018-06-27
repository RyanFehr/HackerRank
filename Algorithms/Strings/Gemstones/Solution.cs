/*
         Problem: https://www.hackerrank.com/challenges/gem-stones/problem
         C# Language Version: 6.0
         .NET Framework Version: 4.7
         Tool Version : Visual Studio Community 2017
         Thoughts (Key points in algorithm):
          - Maintain a map which contains a character (aka mineral) and the count of rocks it has appeared on.
          - A character which hasn't appeared on first rock can never become a gemstone. So from 2nd rock onward if you encounter a mineral which isn't present in the map then just ignore it.
          - Same mineral can occur more than once on same rock. So while processing minerals of a rock we need to keep track if it has already occured on the current rock.
          - Print each mineral in the map whose occurence count is equal to the count of rocks at the end of iteration.

         Gotchas:
            <None>

         Time Complexity:  O(n) //in worst case it will be O(100 n) which is still of order n.
         Space Complexity: O(1) //all space requirements are fixed in nature
                                - a dictionary which contains mineral map will at max have 26 entires in worst case
                                - a hash set tracker for each rock can again contain at max 26 entires and is getting reused in each iteration
                                - Every input string for each rock isn't being stored in memory. we just read one and then throw it away when we iterate next rock.
             
*/

using System.Collections.Generic;
using System;
class Solution
{
    static void Main(string[] args)
    {
        var rockCount = int.Parse(Console.ReadLine());
        var mineralMap = new Dictionary<char, int>();
        var rock = Console.ReadLine();
        foreach (var mineral in rock)
        {
            if (!mineralMap.ContainsKey(mineral))
                mineralMap.Add(mineral, 1);
        }

        for (var i = 1; i < rockCount; i++)
        {
            rock = Console.ReadLine();
            //Use a hash set to ignore a mineral if it is coming more than once on a rock.
            var currentRockUniqueMinerals = new HashSet<char>();
            foreach (var mineral in rock)
            {
                if (mineralMap.ContainsKey(mineral) && !currentRockUniqueMinerals.Contains(mineral))
                {
                    //this mineral has appeared in this rock for the first time and had appeared on rock # 1.
                    mineralMap[mineral]++;
                    currentRockUniqueMinerals.Add(mineral);
                }
            }
        }

        var gemstonesCount = 0;
        foreach (var mineral in mineralMap)
        {
            if (mineral.Value == rockCount)
                gemstonesCount++;
        }
        Console.WriteLine(gemstonesCount);
    }
}
