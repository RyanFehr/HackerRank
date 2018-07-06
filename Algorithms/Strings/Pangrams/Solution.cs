/*
         Problem: https://www.hackerrank.com/challenges/pangrams/problem
         C# Language Version: 6.0
         .Net Framework Version: 4.7
         Tool Version : Visual Studio Community 2017
         Thoughts :
         - Main objective in this problem to check whether all the 26 letters in english alphabet have occured at least once in the input string or not.
            We do this tracking using a number counter. Every time an english letter is found we decrement the counter.
         - How do we track if the current letter is being found in the string for the first time or is getting repeated so that we can decrement our counter appropriately? - We keep an array of length 26 initially all
            initialized to 0. Whenever an alphabet is found toggle its flag in the array.

         Time Complexity:  O(n) //iterating the entire string  might be required in worst case.
         Space Complexity: O(1) //number of dynamically allocated variables remain constant for any input.
             
*/

using System;
class Solution
{
    static void Main(string[] args)
    {
        var alphabetCount = 26;
        var alphabetOccurenceTrack = new int[26];
        var nextChar = Console.Read();
        //special handling for hacker rank execution environment
        //hacker rank uses -1 as end of file character 
        //while running on my computer I compare it against 13.
        while (nextChar != -1)
        {
            if (nextChar >= 97 && nextChar <= 122)
            {
                var arrIndex = nextChar - 97;
                if (alphabetOccurenceTrack[arrIndex] == 0)
                {
                    //a new alphabet out of 26 has been found
                    alphabetCount--;
                    alphabetOccurenceTrack[arrIndex] = 1;
                }

            }

            if (nextChar >= 65 && nextChar <= 90)
            {
                var arrIndex = nextChar - 65;
                if (alphabetOccurenceTrack[arrIndex] == 0)
                {
                    //a new alphabet out of 26 has been found
                    alphabetCount--;
                    alphabetOccurenceTrack[arrIndex] = 1;
                }

            }

            if (alphabetCount == 0)
                break;

            nextChar = Console.Read();
        }

        if (alphabetCount > 0)
            Console.WriteLine("not pangram");
        else
            Console.WriteLine("pangram");
    }
}