/*
    Problem: https://www.hackerrank.com/challenges/plus-minus/problem
    C# Language Version: 6.0
    .Net Framework Version: 4.7
    Tool Version : Visual Studio Community 2017
    Thoughts :
    1. Let there be an array named arr of size n containing all the input numbers.
    2. Lete the count of positive, negative and zero numbers in the array be p,e and z respectively.
    3. Start a for loop to iterate through all the elements of the array
        3.1 Let the current number being iterated is cn.
        3.2 If cn is greater than 0 the increment p by 1.
        3.2 If cn is less than 0 the increment e by 1.
        3.3 If cn is equal to 0 the increment z by 1.
        3.4 Repeat the steps from 3.1 through 3.3 for all the elements of the array.
    4. print p/n on new line.
    5. print e/n on new line.
    6. print z/n on new line.

    Time Complexity:  O(n)
    Space Complexity: O(1) //number of dynamically allocated variables remain constant for any input.
*/

using System;
using static System.Console;

class Solution
{
    static void Main(String[] args)
    {
        var positiveNumbers = 0;
        var negativeNumbers = 0;
        var zeroNumbers = 0;
        //No need to capture the size of array. I use array's length property instead.
        ReadLine();
        var arr_temp = ReadLine().Split(' ');
        var arr = Array.ConvertAll(arr_temp, Int32.Parse);

        for (int arr_i = 0; arr_i < arr.Length; arr_i++)
        {
            if (arr[arr_i] > 0)
                ++positiveNumbers;
            else if (arr[arr_i] < 0)
                ++negativeNumbers;
            else
                ++zeroNumbers;
        }

        WriteLine((double)positiveNumbers / arr.Length);
        WriteLine((double)negativeNumbers / arr.Length);
        WriteLine((double)zeroNumbers / arr.Length);
    }
}