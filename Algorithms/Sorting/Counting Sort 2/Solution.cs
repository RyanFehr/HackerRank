/*
         Problem: https://www.hackerrank.com/challenges/countingsort2/problem
         C# Language Version: 7.0
         .Net Framework Version: 4.7
         Tool Version : Visual Studio Community 2017
         Thoughts :
         1. Let the input array be arr with n elements.
         2. Initialize a new array named numFrequency of size 100. Set each element of numFrequency to 0.
         3. Iterate through all elements of arr in a loop:
            3.1 Let the current element be e.
            3.2 Increase the value at eth index of numFrequency by 1.
         4. Now start a new loop which runs 100 times from 0 to 99
            4.1 Let it be (i)th iteration.
            4.2 Add (i)th element to (i-1)th element and store the sum at (i)th position.
         5. Initialize a new array named sortedOutput of size n.
         6. Start a loop which runs n times:
            6.1 Let it be (i)th iteration.
            6.2 Let the element at (i)th position of arr be num. We've to place num in its correct sorted position in sortedOutput array.
            6.3 Let the element at (num)th position of numFrequency be pos.
            6.4 Decrement the value of the element at (num)th position of numFrequency by 1.
            6.4 Place num at (pos-1)th index in sortedOutput array.
         7. Print all the elements of the sortedOutput (separated by space).
            

         Time Complexity:  O(n+k) // there are two for loops which run n times each one after the other. The loops aren't nested.
                                //Then there is the third loop which runs 100 (= k) times in this case.
         
         Space Complexity: O(n+k) //We require an additional array of size n to store the sorted output array.
                                  //Also, we require an additional array of size 100 (=k) to store the frequence of each number (from 0-99) in the input array. 

        */

using System;
class Solution
{
    static int[] countingSort(int[] inputNumbers)
    {
        var numberFrequency = new int[100];
        for (var i = 0; i < inputNumbers.Length; i++)
            numberFrequency[inputNumbers[i]] += 1;

        //modify frequency array by adding previous counts cumulatively
        for (var i = 1; i < 100; i++)
            numberFrequency[i] += numberFrequency[i - 1];

        var sortedOutput = new int[inputNumbers.Length];

        for (var i = 0; i < inputNumbers.Length; i++)
        {
            var num = inputNumbers[i];
            var position = numberFrequency[num];
            numberFrequency[num] -= 1;
            sortedOutput[position - 1] = num;
        }
        return sortedOutput;
    }

    static void Main(String[] args)
    {
        //No need to capture the size of array. We can use array's length property instead.
        Console.ReadLine();
        var arr_temp = Console.ReadLine().Split(' ');
        var arr = Array.ConvertAll(arr_temp, int.Parse);
        var result = countingSort(arr);
        Console.WriteLine(string.Join(" ", result));
    }
}
