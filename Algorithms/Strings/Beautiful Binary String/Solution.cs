/*
         Problem: https://www.hackerrank.com/challenges/beautiful-binary-string/problem
         C# Language Version: 6.0
         .NET Framework Version: 4.7
         Tool Version : Visual Studio Community 2017
         Thoughts (Key points in algorithm) :
          - The key to approach here is to always change the last character of any "010" substring found in the input text. 
          - It is require to minimize the number of characters to be changed. Changing the last character removes the possibility of encountering "010" sub-stsring in the input text
            using the second zero in the sub-string "010".

         Gotchas:
            - Implementing this algorithm with O(1) space complexity makes it really complex. Implementing it with O(n) space complexity is far more straight forward.

         Time Complexity:  O(n) //We need to iterate the entire string.
         Space Complexity: O(1) //We're reading the input text character by character console input without saving input text it in memory.

 */
using System;

class Solution
{
    static void Main(string[] args)
    {
        //this algorithm uses O(1) space complexity
        const string Ugly_Triplet = "010";
        //No need to capture the length of string. We can use string's length property instead.
        Console.ReadLine();
        var charsChanged = 0;
        var nextChar = Console.Read();

        //Special handling for hacker rank execution environment.
        //Hacker rank uses -1 for end of file which marks the end of input string
        //while running on my own computer I compare it with ascii code of carriage return '\r' which is 13.
        var currentTriplet = "";
        var tripletCounter = 0;
        while (nextChar != -1)
        {
            if (tripletCounter == 0)
            {
                if (nextChar == 48)
                {
                    tripletCounter++;
                    currentTriplet = "0";
                }
            }
            else
            {
                currentTriplet += (char)nextChar;
                if (currentTriplet.Length == 3)
                {
                    if (currentTriplet == Ugly_Triplet)
                    {
                        charsChanged++;
                        tripletCounter = 0;
                    }
                    else if (currentTriplet[2] == '0')
                    {
                        currentTriplet = "0";
                        tripletCounter = 1;
                    }
                    else if (currentTriplet.Substring(1, 2) == "01")
                    {
                        currentTriplet = "01";
                        tripletCounter = 2;
                    }
                    else
                        tripletCounter = 0;
                }
            }
            nextChar = Console.Read();
        }
        Console.WriteLine(charsChanged);
    }

    //a far more simply understood code having O(n) space complexity.
    private static void BeautifulBinaryString2()
    {
        //No need to capture the length of string. We can use string's length property instead.
        Console.ReadLine();
        var inputText = Console.ReadLine();
        var charsChanged = 0;
        for (var i = 0; i < inputText.Length;)
        {
            if (inputText[i] == '0' && i + 2 < inputText.Length)
            {
                var uglySubstring = inputText.Substring(i, 3);
                if (uglySubstring == "010")
                {
                    charsChanged++;
                    i += 3;
                    continue;
                }
            }
            i++;
        }
        Console.WriteLine(charsChanged);
    }
}
