/*
         Problem: https://www.hackerrank.com/challenges/alternating-characters/problem
         C# Language Version: 6.0
         .Net Framework Version: 4.7
         Tool Version : Visual Studio Community 2017
         Thoughts (Key points in algorithm):
         - We've to simply track the alternating characters while traversing the characters of the string
         - If the character being traversed is same as previous character then we need to delete it.
         - For delete operation don't do physical deletion of character from the string. Instead, keep a counter, increment it and move to the next character.
         - Print the counter value in the end.

         Gotchas:
          <None>

         Time Complexity:  O(n) //we need to traverse the entire string
         Space Complexity: O(1) //we are reading every string input in a test case from console input stream character by character 
                                  in place of saving the entire string in memory. So constant space.
*/
using System;
class Solution
{
    static void Main(string[] args)
    {
        var testCaseCount = int.Parse(Console.ReadLine());
        for (var i = 0; i < testCaseCount; i++)
        {
            var deletedCharactercount = 0;
            var nextChar = Console.Read();
            var lastChar = nextChar;

            nextChar = Console.Read();
            //special handling for hacker rank execution environment. 10 is ascii code of line feed '\n'.
            //Hacker rank uses '\n' character for end of a test case and -1 for end of file which marks the end of last test case.
            //while running on my own computer I compare it with ascii code of carriage return '\r' which is 13.
            while (nextChar != 10 && nextChar != -1)
            {
                if (nextChar == lastChar)
                    deletedCharactercount++;
                else
                    lastChar = nextChar;

                nextChar = Console.Read();
            }
            Console.WriteLine(deletedCharactercount);
        }
    }
}