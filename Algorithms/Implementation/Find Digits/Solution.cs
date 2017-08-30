/*
    Problem: https://www.hackerrank.com/challenges/find-digits/problem
    C# Language Version: 6.0
    .Net Framework Version: 4.7
    Tool Version : Visual Studio Community 2017
    Thoughts :
    1. Initialize a variable count c to 0.
    2. Let the input number be n.
    3. Start iterating each digit of the number n in a loop
        3.1 Get next digit of the number n. Let it be d.
        3.2 If d divides n leaving no remainder then increment c by 1.
    4. print c

    Time Complexity:  O(n) //dependent upon the number of digits in the input number
    Space Complexity: O(1) //dynamically allocated variables remain constant irrespective of the size of the input.

*/

using System;

class Solution
{
    static void Main(String[] args)
    {
        var numberOfTestCases = int.Parse(Console.ReadLine());
        for (int a0 = 0; a0 < numberOfTestCases; a0++)
        {
            var n = Console.ReadLine();
            var number = int.Parse(n);
            var digitCount = 0;
            foreach (var item in n)
            {
                if (item == '0')
                    continue;

                if (number % (int)char.GetNumericValue(item) == 0)
                    digitCount++;
            }
            Console.WriteLine(digitCount);
        }
    }
}