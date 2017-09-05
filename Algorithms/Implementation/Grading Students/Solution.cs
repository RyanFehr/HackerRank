/*
 Problem: https://www.hackerrank.com/challenges/grading/problem
 C# Language Version: 6.0
 .Net Framework Version: 4.5.2
 Thoughts :
 1. Start processing grades of n students in a loop one by one
    1.1 Let current student's grade by g.
    1.2 If g is less than 38 then skip steps 1.3 to 1.4 and move to next student's grade.
    1.3 Find the differerence between g and next multiple of 5 if g is greater than or equal to 38.
        Let the difference be d.
    1.4 If d is less than 3 then set the grade of current student to g + d.
 2. Print the processed grades of each student one by one on a new line.

 Time Complexity:  O(n)
 Space Complexity: O(1)
        
*/

using System;

class Solution
{
    static int[] solve(int[] grades)
    {
        for (int i = 0; i < grades.Length; i++)
        {
            var item = grades[i];
            if (item >= 38)
            {
                var diff = 5 - (item % 5);
                if (diff < 3)
                    grades[i] = item + diff;
            }
        }

        return grades;
    }

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] grades = new int[n];
        for (int grades_i = 0; grades_i < n; grades_i++)
            grades[grades_i] = Convert.ToInt32(Console.ReadLine());

        int[] result = solve(grades);
        Console.WriteLine(String.Join("\n", result));
    }
}