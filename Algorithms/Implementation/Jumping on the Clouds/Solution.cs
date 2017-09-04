/*
    Problem: https://www.hackerrank.com/challenges/jumping-on-the-clouds/problem
    C# Language Version: 6.0
    .Net Framework Version: 4.7
    Tool Version : Visual Studio Community 2017
    Thoughts :
    1. Let the type of all clouds is stored in an array of length n. Let us call the array, arr.
    2. Let Emma's initial position be pi. Set pi to 0.
    3. Let the count of jumps required to reach n-1th cloud be cnt.
    4. Start an infinite loop:
        4.1 If pi+2th cloud is ordinary cloud then increment pi by 2 else increment pi by 1.
        4.2 Increment cnt by 1.
        4.3 If pi is now equal to n-1 then break the infinite loop.
    5. Print cnt.

    Time Complexity:  O(n) //At maximum we require to iterate through the array of clouds once.
    Space Complexity: O(n) //The type of all the clouds must be stored in an array to execute the algorithm steps.
*/
using System;
using static System.Console;

class Solution
{

    static void Main(String[] args)
    {
        //No need to capture the size of array. I use array's length property instead.
        ReadLine();
        var c_temp = ReadLine().Split(' ');
        var clouds = Array.ConvertAll(c_temp, int.Parse);

        var emmasPosition = 0;
        var jumpCount = 0;
        while (true)
        {
            if (emmasPosition + 2 <= clouds.Length - 1 && clouds[emmasPosition + 2] == 0)
                emmasPosition = emmasPosition + 2;
            else
                emmasPosition++;

            jumpCount++;
            if (emmasPosition == clouds.Length - 1)
                break;
        }
        WriteLine(jumpCount);
    }
}