/*
         Problem: https://www.hackerrank.com/challenges/grid-challenge/problem
         C# Language Version: 6.0
         .NET Framework Version: 4.7
         Tool Version : Visual Studio Community 2017
         Thoughts (Key points in algorithm):
         - Process each row of the square matrix one by one.
         - Pick a row and sort its elements.
         - Maintain pointers to previous row and current row.
         - After a row is sorted then traverse it from first column to last column and match each element with corresponding
            element in previous row at same position. If any character having bigger ascii value is found in previous row
            then break the iteration of entire Grid as further processing is of no use.
         - Print "YES" if each row is found to be greater than its previous row in column wise comparison.

         Gotchas/Caveats:
          - You can choose any algorithm to sort each row. I chose counting sort to keep the complexity order linear. The input
            data being in the range 97-122 is perfect fit for counting sort.
          - Since there are several test cases present, so breaking the grid iteration mid-way will affect subsequent test cases.
            So it is not possible to apply that improvisation of breaking the grid iteration mid-way.

         Time Complexity:  O(n*(n+k)) //I used counting sort (having time efficient of the order O(n+k)) to sort each row of 
                                        input as they lie in a fixed ascii range from 97 to 122. k=26
         Space Complexity: O(n) //we need to store each row input of length n in memory for sorting it. Other than that, I only 
                                have to store two rows of the grid at a time in memory for column comparison. I don't store 
                                entire matrix/grid in memory.
*/
using System;

class Solution
{
    static void Main(string[] args)
    {
        var testCaseCount = int.Parse(Console.ReadLine());
        for (var i = 0; i < testCaseCount; i++)
        {
            var areColsSorted = "YES";
            var rowColCount = int.Parse(Console.ReadLine());
            //sor the 0th row outside the loop.
            var previousRow = Console.ReadLine().ToCharArray();
            previousRow = CountingSortForAlphabetRange(previousRow);
            for (var j = 1; j < rowColCount; j++)
            {
                //process each row
                if (areColsSorted == "YES")
                {
                    var currentRow = Console.ReadLine().ToCharArray();
                    currentRow = CountingSortForAlphabetRange(currentRow);
                    for (int k = 0; k < currentRow.Length; k++)
                    {
                        if (currentRow[k] < previousRow[k])
                        {
                            areColsSorted = "NO";
                            break;
                        }
                    }
                    previousRow = currentRow;
                }
                else
                    //there is not point processing these rows when an unsorted char series has been already
                    //found in one of the columns.
                    Console.ReadLine();
            }
            Console.WriteLine(areColsSorted);
        }
    }

    static char[] CountingSortForAlphabetRange(char[] characterAsciiCodes)
    {
        var StartingRangeOfAscii = 97;
        var AlphabetRange = 26;
        var numberFrequency = new int[AlphabetRange]; //for small case letters only.
        for (var i = 0; i < characterAsciiCodes.Length; i++)
            numberFrequency[characterAsciiCodes[i] - StartingRangeOfAscii] += 1;

        //modify frequency array by adding previous counts cumulatively
        for (var i = 1; i < AlphabetRange; i++)
            numberFrequency[i] += numberFrequency[i - 1];

        var sortedOutput = new char[characterAsciiCodes.Length];

        for (var i = 0; i < characterAsciiCodes.Length; i++)
        {
            var num = characterAsciiCodes[i];
            var position = numberFrequency[num - StartingRangeOfAscii];
            numberFrequency[num - StartingRangeOfAscii] -= 1;
            sortedOutput[position - 1] = num;
        }
        return sortedOutput;
    }
}