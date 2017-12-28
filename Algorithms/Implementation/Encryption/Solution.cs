/*
 Problem: https://www.hackerrank.com/challenges/encryption/problem
 C# Language Version: 7.0
 .Net Framework Version: 4.7
 Tool Version : Visual Studio Community 2017
 Thoughts :
 1. Let the input string be s.
 2. Let the input string s be of length l.
 3. Get the number of column count when we arrange s as a grid using forumula Ceiling(sqrt(l)). let it be cc.
 4. Start a loop which runs with a counter i starting from 0 to cc-1.
    4.1 Initialize a counter c to 0.
    4.2 start a while loop until i + (c * cc) < l
         4.2.1 print the (i + (c * cc))th character of s on console.
         4.2.2 increment c by 1
    4.3 print a space character on console.
    4.4 repeat steps 4.1 to 4.3 untill loop condition is true.

 Time Complexity:  O(n)
 Space Complexity: O(1) //Number of dynamically allocated variables remain constant for any length of string input.
*/

using System;

class Solution
{
    static void Main(String[] args)
    {

        var englishText = Console.ReadLine();
        var colCount = (int)Math.Ceiling(Math.Sqrt(englishText.Length));

        for (int i = 0; i < colCount; i++)
        {
            var counter = 0;
            while (i + (counter * colCount) < englishText.Length)
            {
                Console.Write(englishText[i + (counter * colCount)]);
                counter++;
            }
            Console.Write(' ');
        }
    }
}
