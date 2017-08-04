/*
 Problem: https://www.hackerrank.com/challenges/angry-professor/problem
 C# Language Version: 6.0
 .Net Framework Version: 4.5.2
 Thoughts :
 1. Start processing each input test case one by one.
 2. In the current test case let there be N students and K be the threshold of cancellation of class.
 3. Initialise a counter onTimeStudents to 0.
 4. Start processing student entry timings for current test case in a loop
    - if student is on time then increase the counter onTimeStudents by 1.
    - if onTimeStudents counter is now equal to K then break the loop.
 5. After processing all the student entry timings using the loop in step 4 
    - if onTimeStudents < K then print YES
    - if onTimeStudents >= K then print NO
 6. Repeat step 2 through 5 for all input test cases.

 Time Complexity:  O(n)
 Space Complexity: O(1)
        
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        var totalTestCases = int.Parse(Console.ReadLine());
            for (int a0 = 0; a0 < totalTestCases; a0++)
            {
                var tokens_n = Console.ReadLine().Split(' ');
                var cancellationThreshold = int.Parse(tokens_n[1]);
                var a_temp = Console.ReadLine().Split(' ');
                var studentEntryTimings = Array.ConvertAll(a_temp, Int32.Parse);
                var onTimeStudents = 0;
                foreach (var studentTiming in studentEntryTimings)
                {
                    if (studentTiming <= 0)
                        onTimeStudents++;

                    if (onTimeStudents == cancellationThreshold)
                        break;
                }

                if (onTimeStudents < cancellationThreshold)
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");

            }
    }
}
