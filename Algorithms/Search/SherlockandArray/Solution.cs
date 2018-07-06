/*
        Problem: https://www.hackerrank.com/challenges/sherlock-and-array/problem
        C# Language Version: 7.0
        .Net Framework Version: 4.7
        Tool Version : Visual Studio Community 2017
        Thoughts :
        - for cases when array lenth is 1 or 2, the decision is straightforward
        - for cases when array length > 2
            - first create the sum of all the elements in the array.
            - Now iterate the elements. Now for each element, sum of left and right elements can be calculated
                easily using simple maths as the sum of all the elements of the array is already available.

        Time Complexity:  O(n) //actually it is O(2n) as effectively we traverse the entire array twice.
        Space Complexity: O(n) //we need to store the input elements in an array for processing.

*/
using System;

class Solution
{
    static void Main(String[] args)
    {

        var testCaseCount = int.Parse(Console.ReadLine());
        for (var a0 = 0; a0 < testCaseCount; a0++)
        {
            //No need to capture the size of array. We can use array's length property instead.
            Console.ReadLine();
            var a_temp = Console.ReadLine().Split(' ');
            var inputNumbers = Array.ConvertAll(a_temp, int.Parse);
            if (inputNumbers.Length == 1)
                Console.WriteLine("YES");
            else if (inputNumbers.Length == 2)
                Console.WriteLine("NO");
            else
            {
                var totalSum = 0;
                foreach (var item in inputNumbers)
                    totalSum += item;

                //calculations for element at 1st index as 0th index element can never satisfy the criterion
                var leftSum = inputNumbers[0];
                var rightSum = totalSum - inputNumbers[1] - inputNumbers[0];
                if (leftSum == rightSum)
                    Console.WriteLine("YES");
                else
                {
                    var i = 2;
                    for (; i < inputNumbers.Length; i++)
                    {
                        leftSum += inputNumbers[i - 1];
                        rightSum -= inputNumbers[i];
                        if (leftSum == rightSum)
                        {
                            Console.WriteLine("YES");
                            break;
                        }
                    }
                    if (i == inputNumbers.Length)
                        Console.WriteLine("NO");
                }
            }
        }

    }
}