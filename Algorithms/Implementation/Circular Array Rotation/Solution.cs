/*
Problem: https://www.hackerrank.com/challenges/circular-array-rotation/problem
C# Language Version: 6.0
.Net Framework Version: 4.5.2
Thoughts :
1. Let there be n numbers in an array a.
2. Initialize another array finalArray of size n.
3. Let total number of rotations be k.
4. Start iterating each element in the array to find final position of each element after all the rotations
are complete:
    4.1 Let loop index be i.
    4.2 Let final index of current element after all rotations be f.
    4.3 Let the number of elements after current element to the end of array be r.
    4.4 If r is less than k then calculte offset o as (k - r) % n. 
        4.4.1 If o is 0 then set f to n-1.
        4.4.2 If o is not 0 then set f to o-1.
    4.5 If r is greater than or equal to k then set f to i + k
    4.6 Set finalArray[f] = a[i]
5. Start iterating each query indeces one by one
    5.1 Let query index be m
    5.2 print finalArray[m]

Time Complexity:  O(n)
Space Complexity: O(n) //an additional array is required to store the final position of all input numbers
                
*/

using System;
using System.Linq;

class Solution
{

    static void Main(String[] args)
    {
        var tokens_n = Console.ReadLine().Split(' ');
        var numberOfElements = int.Parse(tokens_n[0]);
        var numberOfRotations = int.Parse(tokens_n[1]);
        var numberOfQueries = int.Parse(tokens_n[2]);
        var a_temp = Console.ReadLine().Split(' ');
        var inputNumbers = Array.ConvertAll(a_temp, Int32.Parse);

        var finalNumberPositioning = new int[inputNumbers.Count()];

        for (int i = 0; i < numberOfElements; i++)
        {
            var remainingNumbersBeforeEnd = numberOfElements - i - 1;
            var finalIndex = 0;
            if (numberOfRotations > remainingNumbersBeforeEnd)
            {
                var offset = (numberOfRotations - remainingNumbersBeforeEnd) % numberOfElements;
                if (offset == 0)
                    finalIndex = numberOfElements - 1;
                else
                    finalIndex = offset - 1;
            }
            else
            {
                finalIndex = i + numberOfRotations;
            }
            finalNumberPositioning[finalIndex] = inputNumbers[i];
        }

        for (int a0 = 0; a0 < numberOfQueries; a0++)
        {
            var m = int.Parse(Console.ReadLine());
            Console.WriteLine(finalNumberPositioning[m]);
        }
    }
}
