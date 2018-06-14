/*
         Problem: https://www.hackerrank.com/challenges/hackerland-radio-transmitters/problem
         C# Language Version: 7.0
         .Net Framework Version: 4.7
         Tool Version : Visual Studio Community 2017
         Thoughts :

         - the first idea is to sort the house numbers in the input array using quick sort.
         - Secondly we need to keep in mind that any installed radio transmitter will cover houses both on left and right
            hand side. I've done the handling for it inside for loop. See below house numbers which are already sorted for k = 2:

            2 4 5 6 7 9 11 12

            If we install radio transmitter at house # 4 then it will cover house #s 2,4,5,6
            _ ↓ _ _
            2 4 5 6 7 9 11 12

            Next can be installed at house # 9 which will take care of 7,9 & 11
                    _ ↓ _ 
            2 4 5 6 7 9 11 12

            Last transmitter can be installed at house # 12 which will take care of house # 12 only.
                           ↓  
            2 4 5 6 7 9 11 12


         Time Complexity:  O(n log(n)) it involves two parts. Sorting using quick sort which is nlog(n) and one iteration of order O(n)
         Space Complexity: O(n) We need to store the sorted input array in memory to iterate through it.
                
*/
using System.Collections.Generic;
using System.Linq;
using System;

class Solution
{
    static void Main(string[] args)
    {
        var arr_temp = Console.ReadLine().Split(' ');
        //No need to capture the number of houses. We can use array's length property instead.
        var transmissionRange = int.Parse(arr_temp[1]);
        var transmitterCount = 0;
        arr_temp = Console.ReadLine().Split(' ');
        var houseLocations = Array.ConvertAll(arr_temp, int.Parse);

        //sort the array: Contributes O(nlog(n))
        houseLocations = QuickSort2(houseLocations);

        //this loop contributes O(n)
        for (var i = 0; i < houseLocations.Length;)
        {
            var counter = 1;
            while (i + counter < houseLocations.Length
                && houseLocations[i + counter] - houseLocations[i] <= transmissionRange)
                counter++;

            transmitterCount++;//install a transmitter
            i = i + counter - 1; //array index of the house where we just installed a transmitter

            //now find the index of next house which is out of range from the transmitter we've just installed above.
            counter = 1;
            while (i + counter < houseLocations.Length
                && houseLocations[i + counter] - houseLocations[i] <= transmissionRange)
                counter++;

            i += counter;

        }
        Console.WriteLine(transmitterCount);
    }

    static int[] QuickSort2(int[] arr)
    {
        var pivot = arr[0];
        var smallerItems = new List<int>();
        var equalItems = new List<int>();
        var biggerItems = new List<int>();
        var outputArr = new int[arr.Length];

        equalItems.Add(arr[0]);

        for (var i = 1; i < arr.Length; i++)
        {
            if (arr[i] < pivot)
                smallerItems.Add(arr[i]);
            else if (arr[i] > pivot)
            {
                biggerItems.Add(arr[i]);
            }
            else
                equalItems.Add(arr[i]);
        }

        if (smallerItems.Count > 1)
            smallerItems = QuickSort2(smallerItems.ToArray()).ToList();

        if (biggerItems.Count > 1)
            biggerItems = QuickSort2(biggerItems.ToArray()).ToList();

        var j = 0;

        foreach (var item in smallerItems)
            outputArr[j++] = item;

        foreach (var item in equalItems)
            outputArr[j++] = item;


        foreach (var item in biggerItems)
            outputArr[j++] = item;

        return outputArr;
    }
}