/*
    Problem: https://www.hackerrank.com/challenges/counting-valleys
    C# language Version: 6.0
    .Net Framework Version: 4.5.2
    Thoughts: 
    1. Set a counter seaLevel to 0.
    2. Set a boolean isValleyActive to false.
    3. Set a counter valleyCount to 0.
    4. After every step:
        2.1 increment the seaLevel by 1 if it is uphill step and decrement it by 1 if it is a downhill step.
        2.2 If there is no valley currently active(i.e. isValleyActive was false until this step) and if seaLevel 
        has become negative after current step means we have started traversing a valley then set the boolean 
        isValleyActive to true.
        2.3 If we were already traversing a valley(i.e. isValleyActive was true until this step) and if seaLevel 
        has become zero after current step means we have just finishing traversing a valley then set the boolean 
        isValleyActive to false and increment valleyCount by 1.
    5. Keep repeating step 4 untill all steps are iterated.
    6. Print valleyCount

    Time Complexity:  O(n)
    Space Complexity: O(1)
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution 
{
    static void Main(String[] args) 
    {
        var seaLevel = 0;
        var valleyCount = 0;
        var totalNumberOfSteps = int.Parse(Console.ReadLine());
        var garyStepRecord = Console.ReadLine().ToArray();
        var isValleyActive = false;

        for (int i = 0; i < totalNumberOfSteps; i++)
        {
            if (garyStepRecord[i] == 'U')
            {
                seaLevel++;
            }
            else
            {
                seaLevel--;
            }

            if (!isValleyActive && seaLevel < 0)
            {
                isValleyActive = true;
            }

            if (isValleyActive && seaLevel == 0)
            {
                valleyCount++;
                isValleyActive = false;
            }
        }
        Console.WriteLine(valleyCount);
    }
}
