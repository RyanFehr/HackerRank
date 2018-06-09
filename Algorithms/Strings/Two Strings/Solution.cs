/*
         Problem: https://www.hackerrank.com/challenges/two-strings/problem
         C# Language Version: 6.0
         .Net Framework Version: 4.7
         Tool Version : Visual Studio Community 2017
         Thoughts (Key points in algorithm):
         - It is about finding just one character in first string which will also be present in second string.
         - Iterate the first string and create a set (hash set for O(1) ammortized searching) of all the english alphabet characters appearing in it.
         - Then, iterate the second string and check if any of the characters appearing is present in the character set of first string.
         - If found print YES else print NO.

         Gotchas:
          <None>

         Time Complexity:  O(m + n) //m and n are length of the input strings respectively.
         Space Complexity: O(1) 

        */
using System.Collections.Generic;
using System;

class Solution {
    static void Main(string[] args) {
       var testcaseCount = int.Parse(Console.ReadLine());
            while (testcaseCount > 0)
            {
                var text1nextChar = Console.Read();
                var charMap = new HashSet<int>();
                //special handling for hacker rank execution environment.
                //for line break they use '\n' whose ascii code is 10
                //on my local box I use 13 which is ascii code for '\r'
                while (text1nextChar != 10)
                {
                    
                        if (!charMap.Contains(text1nextChar))
                            charMap.Add(text1nextChar);
                    
                    text1nextChar = Console.Read();
                }

                var charFound = "NO";
                var text2nextChar = Console.Read();
                //special handling for hacker rank execution environment.
                //for end of file they use -1 which is the end of second string of last test case.
                while (text2nextChar != 10 && text2nextChar != -1)
                {
                    if (charMap.Contains(text2nextChar) && charFound != "YES")
                        charFound = "YES";
                    text2nextChar = Console.Read();
                }

                Console.WriteLine(charFound);
                testcaseCount--;
            }
    }
}