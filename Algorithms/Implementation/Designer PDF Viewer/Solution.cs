/*
 Problem: https://www.hackerrank.com/challenges/designer-pdf-viewer/problem
 C# Language Version: 6.0
 .Net Framework Version: 4.5.2
 Thoughts :
 1. Put height of each alphabet in a dictionary. Let the dictionary be alphabetHeight.
 2. Obtain the maximum height of all the alphabets present in input word. Let it be maxAlphabetHeight.
 3. Print the product of maxAlphabetHeight and length of input word.

 Time Complexity:  O(n)
 Space Complexity: O(1) //Only seven dynamically allocated variables which will remain constant irrespective of input.
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
            var h_temp = Console.ReadLine().Split(' ');
            var inputHeights = Array.ConvertAll(h_temp, Int32.Parse);
            var alphabetHeight = new Dictionary<char, int>();

            var alphabet = 'a';
            foreach (var height in inputHeights)
            {
                alphabetHeight.Add(alphabet++, height);
            }

            var maxAlphabetHeight = 0;
            string word = Console.ReadLine();
            foreach (var letter in word)
            {
                if (alphabetHeight[letter] > maxAlphabetHeight)
                {
                    maxAlphabetHeight = alphabetHeight[letter];
                }
            }

            var areaOfSelectedText = maxAlphabetHeight * word.Length;
            Console.WriteLine(areaOfSelectedText);
    }
}
