using System;

namespace ConsoleApp.HackerRank
{
    /*
        Problem: https://www.hackerrank.com/challenges/2d-array/problem
        C# Language Version: 6.0
        .NET Framework Version: 4.7
        Tool Version : Visual Studio Community 2015
        Thoughts (Key points in algorithm) :
        1. Take input strings in an string array 
        2. Split input strings and create 2D integer array of 6 X 6
        3. take an integer to keep highest value of hourglass (call it hgSum) and assigned to int.minVal initially.
        4. Run a loop for Row-2 times (row wise)
        5. While iterating row, run a loop for column-2 times (column wise)
        6. Sum each Hourglass in that row and replace value of hgSum with it if it is greater than that.
        
        Gotchas:
        <None>

        Time Complexity:  O(n2) //looping throgh the splitted array
        Space Complexity: O(n) //initializing an array that stores splitted string elements.
    */
    class _2DArrayDS
    {
        public static void Execute()
        {
            var hourGlassStrings = new string[6];
            for (var i = 0; i < 6;)
                hourGlassStrings[i++] = Console.ReadLine();

            var hourglassMatrix = new int[6, 6];
            for (var i = 0; i < 6; i++)
            {
                var counter = 0;
                foreach (var item in hourGlassStrings[i].Split(' '))
                    hourglassMatrix[i, counter++] = int.Parse(item);
            }
            Console.WriteLine(GetHigheshHourglassSum(hourglassMatrix));
            Console.ReadLine();
        }

        private static int GetHigheshHourglassSum(int[,] hourglassMatrix)
        {
            int highestSum = int.MinValue;
            for (var i = 0; i < 4; i++)
            {
                for (var j = 0; j < 4; j++)
                {
                    var sum = hourglassMatrix[i, j] + hourglassMatrix[i, j + 1] +
                              hourglassMatrix[i, j + 2] + hourglassMatrix[i + 1, j + 1] +
                              hourglassMatrix[i + 2, j] + hourglassMatrix[i + 2, j + 1] +
                              hourglassMatrix[i + 2, j + 2];
                    if (highestSum < sum)
                        highestSum = sum;
                }
            }
            return highestSum;
        }
    }
}
