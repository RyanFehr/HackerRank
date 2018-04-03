/*
    Problem: https://www.hackerrank.com/challenges/tutorial-intro/problem
    C# Language Version: 6.0
    .Net Framework Version: 4.7
    Tool Version : Visual Studio Community 2017
    Thoughts :
    1. Let the value to be searched in array is v.
    2. Let the index of v in the array be i. Initialize i to 0.
    3. Start a loop:
    3.1 If the element in the array at index i is same as v then break the loop and go to step 4.
    3.2 increment i by 1.
    3.3 Keep repeating the steps from 3.1 through 3.2 untill loop breaking condition is not met.
    4. Print i on console.

    Time Complexity:  O(n) //one for loop to iterate array elements.
    Space Complexity: O(1) //number of dynamically allocated variables remain constant for any input.
             
*/
using System;

class Solution
{
    static int IntroTutorial(int v, int[] arr)
    {
        var i = 0;
        for (; i < arr.Length; i++)
        {
            if (arr[i] == v)
                break;
        }
        return i;
    }

    static void Main(String[] args)
    {
        var v = int.Parse(Console.ReadLine());
        //no need to save the number of elements in the array.
        Console.ReadLine();
        var arr_temp = Console.ReadLine().Split(' ');
        var arr = Array.ConvertAll(arr_temp, Int32.Parse);
        var result = IntroTutorial(v, arr);
        Console.WriteLine(result);
    }
}
