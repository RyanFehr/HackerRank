
using System;

/*
             Problem: https://www.hackerrank.com/challenges/arrays-ds/problem
             C# Language Version: 6.0
             .NET Framework Version: 4.7
             Tool Version : Visual Studio Community 2015
             Thoughts (Key points in algorithm) :
             1. Split integer string (2nd line input) on space character.
             2. Run through this splitted array from last index to 0 and print with space. 

             Gotchas:
                <None>

             Time Complexity:  O(n) //looping throgh the splitted array
             Space Complexity: O(n) //initializing an array that stores splitted string elements.

        */


class Solution
{

    private static void PrintStringInReverseOrder(int totalIntegers, string integerString)
    {
        var strArray = integerString.Split(' ');
        for (--totalIntegers; totalIntegers >= 0;)
        {
            Console.Write(strArray[totalIntegers--]);
            if (totalIntegers >= 0)
                Console.Write(" ");
        }
    }
    static void Main(string[] args)
    {

        var totalIntegers = int.Parse(Console.ReadLine());
        var integerString = Console.ReadLine();
        PrintStringInReverseOrder(totalIntegers, integerString);
        Console.ReadLine();

    }
}
