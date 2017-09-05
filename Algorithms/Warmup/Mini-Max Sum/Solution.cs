/*
    Problem: https://www.hackerrank.com/challenges/mini-max-sum/problem
    C# Language Version: 6.0
    .Net Framework Version: 4.7
    Tool Version : Visual Studio Community 2017
    Thoughts :
    1. Store all the input five numbers in an array.
    2. Let the highest and lowest number in the array be h and l. Initialize h to 0 and l to greatest possible number (max of
       the data type in the programming language).
    3. Let the sum of all five numbers in the array be s. Initialize s to 0.
    4. Iterate through five elements of array using a loop
       4.1 Let the current number be c.
       4.2 Increment s by c.
       4.3 If c is less than l then set l to c.
       4.4 If c is greater than h then set h to c.
       4.5 Repeat steps 4.1 through 4.4 for all five elements of the array.
    5. Print the outcome of s - h and s - l on the same line on console separated by space.

    Time Complexity:  O(1) //even though there is a for loop in the algorithm but the problem statement says that number of elements will always be fixed at 5. Since the number of input is not variable so complexity will be O(1). Since the number of input elements is fixed at 5 so the same solution can be implemented using few if-else statements also.
    Space Complexity: O(1) //number of dynamically allocated variables remain constant for any input.
*/

using System;
using static System.Console;
using System.Linq;

class Solution
{

    static void Main(String[] args)
    {
        var numbers = ReadLine().Split(' ').Select(x => long.Parse(x)).ToList();
        var sumOfAllNumbers = 0L;
        var minimum = long.MaxValue;
        var maximum = 0L;
        for (int i = 0; i < 5; i++)
        {
            sumOfAllNumbers += numbers[i];
            if (numbers[i] < minimum)
                minimum = numbers[i];

            if (numbers[i] > maximum)
                maximum = numbers[i];

        }
        WriteLine(string.Format("{0} {1}", sumOfAllNumbers - maximum, sumOfAllNumbers - minimum));
    }
}