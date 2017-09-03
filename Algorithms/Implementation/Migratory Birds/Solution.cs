/*
    Problem: https://www.hackerrank.com/challenges/migratory-birds/problem
    C# Language Version: 6.0
    .Net Framework Version: 4.7
    Tool Version : Visual Studio Community 2017
    Thoughts :
    1. Let there be an array arr of length n containing the type of all the migratory birds.
    2. Declare another array ac of length 5 to store the count of five different types of migratory birds. Initialize all the counts to 0.
    3. Iterate the elements in the array arr in a loop
        3.1 Let the type of current bird be t.
        3.2 Increment the count of bird type t stored in array ac by 1.
        3.3 Repeat the steps from 4.1 through 4.2 for all the migratory birds in the flock.
    4. Let the type of bird having maximum count be mb. Let the total count of mb bird cb.
    Initialize mb to 1. Initialize cb to ac[0].
    5. Iterate the elements in the array ac in a loop starting from the second element
        5.1 Let the current loop counter be i.
        5.2 If count of (i+1) bird type is greater than cb then set mb to (i+1) and cb to count of (i+1) bird type.
        5.3 If count of (i+1) bird type is equal than cb and (i+1) is less than mb then set mb to (i+1).
        5.4 Repeat steps from 5.1 through 5.3 for remaining elements of the array.
    6. Print mb.
         
    Time Complexity:  O(n) There are two for loops but second for loop runs a constant (=5) number of times. 
                        Hence second loop can be ignored.
    Space Complexity: O(1) //We are allocating an additional array which is of constant length (=5). So it will not vary with the
                            number of migratory birds. Other dynamically allocated variables remain constant for any input.
                
*/
using System;
using static System.Console;
using System.Collections.Generic;

class Solution
{
    static void Main(String[] args)
    {
        //No need to capture the size of array. I use array's length property instead.
        ReadLine();
        var ar_temp = ReadLine().Split(' ');
        var ar = Array.ConvertAll(ar_temp, int.Parse);
        var result = MigratoryBirds(ar);
        WriteLine(result);
    }

    static int MigratoryBirds(int[] ar)
    {
        var birdTypeCounts = new int[5];

        for (int i = 0; i < ar.Length; i++)
            birdTypeCounts[ar[i] - 1]++;

        var maxBirdTypeCount = birdTypeCounts[0];
        var maxBirdType = 1;

        for (int i = 1; i < 5; i++)
        {
            if (birdTypeCounts[i] > maxBirdTypeCount)
            {
                maxBirdTypeCount = birdTypeCounts[i];
                maxBirdType = i + 1;
            }

            if (birdTypeCounts[i] == maxBirdTypeCount && i + 1 < maxBirdType)
                maxBirdType = i + 1;
        }

        return maxBirdType;
    }
}