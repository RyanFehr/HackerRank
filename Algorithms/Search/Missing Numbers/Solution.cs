/*
        Problem: https://www.hackerrank.com/challenges/missing-numbers/problem
        C# Language Version: 6.0
        .Net Framework Version: 4.7
        Tool Version : Visual Studio Community 2017
        Thoughts :

          Simple brute force method:

         - use a sorted dictionary to keep the frequency of any number which is appearing in arrB.
         - then iterate arrA and decrement its frequency in the sorted dictionary lookup
         - now iterate the dictionary and print the key whereever the value > 0
         - Since it is a sorted dictionary so keys will be in increasing order.

        By finding the minimum in arrB method:

         - first iterate arrB and find the smallest value
         - now maintain two frequence arrays arrFreqB and arrFreqA.
         - Again iterate arrB and fill-up arrFreqB so that frequency of smallest value at index 0 and so on.
         - Iterate arrA and fill-up freqA so that frequency of smallest value at index 0 and so on.
         - Now iterate arrFreqB. If for any position there is a mismatch in corresponding value in arrFreqA then print the
           number. Number can be obtained by adding the curent index with smallest value in arrB.

       Pivot method (Current implementation)
        - Here we take up first element of arrB as our pivot element.
        - All the remaining elments in the array can be spread 100 ahead or 100 behind.
        - So we take up the frequency array of size 201
        - first iterate arrB and fill up the frequency of each number by finding its index w.r.t. pivot element
        - Then iterate arrA and decrement the frequency of each number by finding its index w.r.t. pivot element.
        - Iterate the frequency array and print the nummber wherever frequency > 0. Number to be printed will have to caculated using pivot and current index.



        Time Complexity:  O(n) //We need to iterate both the source arrays once.
        Space Complexity: O(n) //input numbers need to be stored in array + an array of 200 constant length

*/
using System;

class Solution
{
    static void Main(string[] args)
    {
        //No need to capture the number of items. We'll use for loop to iterate the list items
        Console.ReadLine();
        var arr_temp = Console.ReadLine().Split(' ');
        var arrA = Array.ConvertAll(arr_temp, int.Parse);
        //No need to capture the number of items. We'll use for loop to iterate the list items
        Console.ReadLine();
        arr_temp = Console.ReadLine().Split(' ');
        var arrB = Array.ConvertAll(arr_temp, int.Parse);

        var frequency = new int[201];
        frequency[100] = 1;

        var pivot = arrB[0];
        for (var i = 1; i < arrB.Length; i++)
        {
            var diff = arrB[i] - pivot;
            frequency[100 + diff]++;
        }

        for (var i = 0; i < arrA.Length; i++)
        {
            var diff = arrA[i] - pivot;
            frequency[100 + diff]--;
        }

        for (var i = 0; i < frequency.Length; i++)
        {
            if (frequency[i] > 0)
                Console.Write(string.Format("{0} ", pivot + (i - 100)));
        }
    }
}
