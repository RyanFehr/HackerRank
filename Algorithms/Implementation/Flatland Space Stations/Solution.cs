/*
         Problem: https://www.hackerrank.com/challenges/flatland-space-stations/problem
         C# Language Version: 7.0
         .Net Framework Version: 4.7
         Tool Version : Visual Studio Community 2017
         Thoughts :
         1. First set up bool array arr of all cities and mark all the space station cities with true.
         2. Consider two indexes namely prev and next which represent indexes of previous and next space stations for any given 
            city. Initialize both to -1.
         3. Initialize maxOfMin (which will keep track of the maximum distance found for any city from a space station) to zero.
         4. Iterate through each city:
            - If the city is a space station then set prev index of a space station to current city's index.
            - If the city is not a space station then work out the prev and next space station indexes if they are not appropriately set.
              Then find its minimum distance from either of prev or next space station indexes.
              If the minimum distance found is greater than maxOfMin then set maxOfMin to new value.

              A point of caution is that the next space station index can become stale once in a while when we have crossed it during
              iteration so it will have to be searched again whenever the case happens.

        5. Print maxOfMin on the screen.

         Time Complexity:  O(n) //there are no nested loops. There will be some extra traversals here and there to get nearest
                                //previous or next space station.
         Space Complexity: O(n) //We have taken an array to store the presence/absence of a space station at each city of Flatland.
                
        */

using System;

class Solution
{
    static int FlatlandSpaceStations(int n, int[] spaceStationIndexes)
    {
        var maxOfMin = 0;
        //we can use bit array instead to save space but bool[] is way more faster.
        //when I tried bit array then test case # 18 and 19 were resulting in time out.
        var cities = new bool[n];

        for (var i = 0; i < spaceStationIndexes.Length; i++)
            cities[spaceStationIndexes[i]] = true;

        var previousSpaceStation = -1;
        var nextSpaceStation = -1;
        for (var i = 0; i < n; i++)
        {
            var isSpaceStation = cities[i];
            var currentMin = 0;
            if (isSpaceStation)
                previousSpaceStation = i;
            else
            {
                if (previousSpaceStation == -1 && nextSpaceStation == -1)
                {
                    //find next space station. You are guaranteed to find a space station in forward direction
                    //as there is a minimum of one space station in cities array. So traverse forward without bounds check.
                    var j = i;
                    while (!cities[j])
                        j++;

                    nextSpaceStation = j;
                    currentMin = nextSpaceStation - i;

                }

                else if (previousSpaceStation > -1 && nextSpaceStation == -1)
                {
                    //find next space station. Then set currentMin
                    if (IsNextSpaceStationPresent(cities, i, out nextSpaceStation))
                    {
                        if (nextSpaceStation - i < i - previousSpaceStation)
                            currentMin = nextSpaceStation - i;
                        else
                            currentMin = i - previousSpaceStation;
                    }
                    else
                        currentMin = i - previousSpaceStation;

                }



                else if (previousSpaceStation == -1 && nextSpaceStation > -1)
                {
                    //no calculation required. Just set currentMin
                    currentMin = nextSpaceStation - i;
                }

                else if (previousSpaceStation > -1 && nextSpaceStation > -1)
                {
                    if (nextSpaceStation > i)
                    {
                        //we're in middle of two space stations. Find which is nearest and set
                        if (nextSpaceStation - i < i - previousSpaceStation)
                            currentMin = nextSpaceStation - i;
                        else
                            currentMin = i - previousSpaceStation;
                    }
                    else
                    {
                        //find next space station. Then set currentMin
                        if (IsNextSpaceStationPresent(cities, i, out nextSpaceStation))
                        {
                            if (nextSpaceStation - i < i - previousSpaceStation)
                                currentMin = nextSpaceStation - i;
                            else
                                currentMin = i - previousSpaceStation;
                        }
                        else
                            currentMin = i - previousSpaceStation;
                    }

                }
            }

            if (currentMin > maxOfMin)
                maxOfMin = currentMin;

        }

        return maxOfMin;
    }

    private static bool IsNextSpaceStationPresent(bool[] cities, int startIndex, out int nextSpaceStationIndex)
    {
        var spaceStationfound = false;
        nextSpaceStationIndex = -1;
        for (; startIndex < cities.Length; startIndex++)
        {
            if (cities[startIndex])
            {
                spaceStationfound = true;
                nextSpaceStationIndex = startIndex;
                break;
            }
        }
        return spaceStationfound;
    }

    static void Main(String[] args)
    {
        var tokens_n = Console.ReadLine().Split(' ');
        var n = int.Parse(tokens_n[0]);
        var c_temp = Console.ReadLine().Split(' ');
        var c = Array.ConvertAll(c_temp, int.Parse);
        int result = FlatlandSpaceStations(n, c);
        Console.WriteLine(result);
    }
}
