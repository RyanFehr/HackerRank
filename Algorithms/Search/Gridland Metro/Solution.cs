/*
        Problem: https://www.hackerrank.com/challenges/gridland-metro/problem
        C# Language Version: 6.0
        .Net Framework Version: 4.7
        Tool Version : Visual Studio Community 2017
        Thoughts :
        - Create a map for for each row number where a track is present. If there are more than one track on a given row it will become a list. e.g.
           Row Number      List of Tracks
           1               (2,3), (1,4), (3,6)
           2               (2,6)
           3               (1,4), (3,6)
        - Start with a total cell counter which keeps a track of total possible cells in the grid land matrix. So for 4x4 matrix it will be 16.
        - Deduct the number of cells occupied by every track from the total cell counter.

        Gotchas:
        - If the list of tracks on any row > 1 then overlapping intervals need to be merged.
        - Total cell counter must be of long type. Value n*m can't be held in Int32. It will result in range overflow.


        Time Complexity:  O(k) //k is number of tracks. Time complexity involved in sorting and merging the ranges of tracks on a given row can be ignored
        Space Complexity: O(k) //k is number of tracks. We need to store the map of ranges of tracks

*/

using System;
using System.Collections.Generic;
using System.Linq;
class Solution
{
    static void Main(string[] args)
    {
        var arr_temp = Console.ReadLine().Split(' ');
        var rowCount = long.Parse(arr_temp[0]);
        var colCount = long.Parse(arr_temp[1]);
        var trackCount = int.Parse(arr_temp[2]);
        var totalEmptyCells = rowCount * colCount;
        var trackMap = new Dictionary<int, List<Tuple<int, int>>>();
        //this for loop contributes O(k)
        for (int i = 0; i < trackCount; i++)
        {
            arr_temp = Console.ReadLine().Split(' ');
            var rowNumber = int.Parse(arr_temp[0]);
            var colStart = int.Parse(arr_temp[1]);
            var colEnd = int.Parse(arr_temp[2]);

            //processing logic.
            if (trackMap.ContainsKey(rowNumber))
            {
                var existingList = trackMap[rowNumber];
                existingList.Add(Tuple.Create(colStart, colEnd));
            }
            else
                trackMap.Add(rowNumber, new List<Tuple<int, int>> { Tuple.Create(colStart, colEnd) });
        }


        //now again iterate through all the track ranges map in each row and decrement totalEmptyCells variable

        //this for loop contributes O(k) in worst case or < O(k) if there are overalapping tracks.
        foreach (var item in trackMap)
        {
            var trackRanges = item.Value;
            if (trackRanges.Count == 1)
                totalEmptyCells -= trackRanges[0].Item2 - trackRanges[0].Item1 + 1;
            else
            {
                //merge the ranges of overlapping tracks
                trackRanges = MergeOverlappingIntervals(trackRanges);
                //after merging do the subtraction sturff
                foreach (var trackRange in trackRanges)
                    totalEmptyCells -= trackRange.Item2 - trackRange.Item1 + 1;
            }
        }
        Console.WriteLine(totalEmptyCells);
    }

    private static List<Tuple<int, int>> MergeOverlappingIntervals(List<Tuple<int, int>> trackRanges)
    {
        trackRanges = QuickSortTuples(trackRanges);
        var stack = new Stack<Tuple<int, int>>();
        stack.Push(trackRanges[0]);
        for (var i = 1; i < trackRanges.Count; i++)
        {
            var tupleOnTop = stack.Peek();
            if (tupleOnTop.Item2 < trackRanges[i].Item1)
                stack.Push(trackRanges[i]);//no overlap
            else if (tupleOnTop.Item2 < trackRanges[i].Item2)
            {
                var poppedTuple = stack.Pop();
                stack.Push(Tuple.Create(poppedTuple.Item1, trackRanges[i].Item2));
            }
        }
        return stack.ToList();
    }

    static List<Tuple<int, int>> QuickSortTuples(List<Tuple<int, int>> inputList)
    {
        var pivot = inputList[0];
        var smallerItems = new List<Tuple<int, int>>();
        var equalItems = new List<Tuple<int, int>>();
        var biggerItems = new List<Tuple<int, int>>();
        var sortedList = new List<Tuple<int, int>>();

        equalItems.Add(inputList[0]);

        for (var i = 1; i < inputList.Count; i++)
        {
            if (inputList[i].Item1 < pivot.Item1)
                smallerItems.Add(inputList[i]);
            else if (inputList[i].Item1 > pivot.Item1)
                biggerItems.Add(inputList[i]);
            else
                equalItems.Add(inputList[i]);
        }

        if (smallerItems.Count > 1)
            smallerItems = QuickSortTuples(smallerItems);

        if (biggerItems.Count > 1)
            biggerItems = QuickSortTuples(biggerItems);

        sortedList.AddRange(smallerItems);
        sortedList.AddRange(equalItems);
        sortedList.AddRange(biggerItems);

        return sortedList;
    }
}
