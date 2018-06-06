/*
        Problem: https://www.hackerrank.com/challenges/caesar-cipher-1/problem
        C# Language Version: 6.0
        .Net Framework Version: 4.7
        Tool Version : Visual Studio Community 2017
        Thoughts :
            - we only have to process a character in the input text if it is an alphabet else print it directly on console.
            - produce the encoded character for each alphabet in input text by moving it in the alphabet series shift factor steps. 
            - A cautionary step is when the shift factor is > 26. If it is the case then get the shift factor by doing a modulus
                so that it becomes <= 26.

        Time Complexity:  O(n) //iteration of whole input text is required once. 
        Space Complexity: O(n) //we need to store the entire input text in memory to process it.

*/

using System;

class Solution
{
    static void Main(string[] args)
    {
        //No need to capture the size of string. We can use string's length property instead.
        Console.ReadLine();
        var inputText = Console.ReadLine();
        var shiftFactor = int.Parse(Console.ReadLine());
        if (shiftFactor > 26)
            shiftFactor = shiftFactor % 26;

        for (var i = 0; i < inputText.Length; i++)
        {
            var asciiCode = (int)inputText[i];
            if (asciiCode <= 122 && asciiCode > 96)
            {
                //small case alphabets
                if (asciiCode + shiftFactor <= 122)
                    //we're within range. Replace the encoded character
                    Console.Write((char)(((int)inputText[i]) + shiftFactor));
                else
                {
                    var offset = shiftFactor - (122 - asciiCode);
                    Console.Write((char)(96 + offset));
                }
            }
            else if (asciiCode <= 90 && asciiCode > 64)
            {
                //upper case alphabets
                if (asciiCode + shiftFactor <= 90)
                    //we're within range. Replace the encoded character
                    Console.Write((char)(((int)inputText[i]) + shiftFactor));
                else
                {
                    var offset = shiftFactor - (90 - asciiCode);
                    Console.Write((char)(64 + offset));
                }
            }
            else
                Console.Write(inputText[i]);

        }

    }
}