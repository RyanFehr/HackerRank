/*
    Problem: https://www.hackerrank.com/challenges/equality-in-a-array/problem
    C# Language Version: 6.0
    .Net Framework Version: 4.7
    Tool Version : Visual Studio Community 2017
    Thoughts :
    1. Let all the numbers are stored in an array of length n.
    2. Create a hash map which will store the frequency of occurrence of every number appearing in the array.
    3. Iterate through the array using a loop:
    3.1 Let the current number be cn.
    3.2 If cn key is absent in hash map then add a new key-value pair into the hashmap with key = cn and value = 1.
    3.3 If cn key is present in hash map then increment the value of the dictionary entry by 1 where key = cn.
    3.4 Repeat steps 3.1 through 3.3 for all the elements of the array.
    4. Iterate through hash map and get the highest value present across all dictionary entries. Let it is be vMax.
    5. Print the difference of n and vMax on console.

    Time Complexity:  O(n) //actually it is O(2n) which becomes O(n) ignoring constants as per Big O notation.
    Space Complexity: O(n) //we are creating an additional hash map to store the frequency of numbers appearing in the input array.
                
*/
using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    static void Main(String[] args)
    {
        var hashMap = new Dictionary<int, int>();
        //no need of storing the number count as I use length of the array property.
        ReadLine();
        var ar_temp = ReadLine().Split(' ');
        var numbers = Array.ConvertAll(ar_temp, int.Parse);

        for (int i = 0; i < numbers.Length; i++) //O(n)
        {
            if (hashMap.ContainsKey(numbers[i]))
                hashMap[numbers[i]]++;
            else
                hashMap.Add(numbers[i], 1);
        }

        var maxFrequency = hashMap.Values.Max(); //O(n)
        WriteLine(numbers.Length - maxFrequency);
    }
}