/*
 Problem: https://www.hackerrank.com/challenges/separate-the-numbers/problem
 C# Language Version: 6.0
 .Net Framework Version: 4.7
 Tool Version : Visual Studio Community 2017
 Thoughts :
 - Basic strategy is to split the input string into strings of width starting from 1,2,3 and so on. For each width check if each subsequent number is a successor of the previous number.
    e.g. 111213
    for this first we take width = 1 - Numbers thus found are 1,1,1,2,1,3. It fails at second split itself as the series should go like 1,2,3,4,....
    then we take width = 2 - Numbers thus found are 11,12,13 which is a proper increasing series. We print YES 11 in this case.
 - Handling for conditions given in the problem statement need to be done i.e. if a part contains leading zero then we need to reject the series.

 Gotchas: Following things require special handling
 - Handling for switch over of digit width. e.g. the string 91011. You start with width 1 but you've to suddenly jumnp to 2 as 9 is largest one digit number
 - Int32 is not sufficient. We need to use Int64 i.e. long
 - Special handling for boundary case of short strings e.g. 90190290

 Time Complexity:  O(n) //if we do a manual calculation then for each test case the loop runs are in the order of ~ O(3n)
                        //e.g. for n = 32 the loop runs 111 times
                               for n = 16  the loop runs 46 times and so on.
 Space Complexity: O(n) we save the input string in memory to process it.

*/
using System;

class Solution
{
    private static void SeparateNumbers(string inputText)
    {
        var numberWidth = 1;
        var found = false;
        while (numberWidth <= inputText.Length / 2)
        {
            var textPart = inputText.Substring(0, numberWidth);
            if (IsFirstCharZero(textPart))
            {
                numberWidth++;
                continue;
            }

            //handling for big numbers. Int64 is being used
            var previousNum = long.Parse(textPart);
            var firstNum = previousNum;
            var j = numberWidth;
            var widthChangeFactor = 0;

            //handling for width change over. e.g. in number 91011. the number series is 9,10,11. Width being extracted will change at 10 from 1 to 2 as 9 is largest one digit number
            if (IsItLargestNDigitNumber(textPart, numberWidth))
                widthChangeFactor++;

            //special handling: step block of for loop has been left empty. It is being done inside the for loop itself as it will vary depending upon condition.
            for (; j < inputText.Length;)
            {
                //handling for short strings. e.g. 90190290 will break in last triplet as it consists of 901,902,90
                if (j + numberWidth + widthChangeFactor > inputText.Length)
                    break;
                else
                    textPart = inputText.Substring(j, numberWidth + widthChangeFactor);

                if (IsFirstCharZero(textPart))
                    break;

                var currentNum = long.Parse(textPart);
                if (currentNum - previousNum != 1)
                    break;

                if (IsItLargestNDigitNumber(textPart, numberWidth + widthChangeFactor))
                {
                    widthChangeFactor++;
                    j += numberWidth;
                }
                else
                    j += numberWidth + widthChangeFactor;

                previousNum = currentNum;
            }

            if (j >= inputText.Length)
            {
                found = true;
                Console.WriteLine("YES {0}", firstNum);
                break;
            }

            numberWidth++;
        }
        if (!found)
            Console.WriteLine("NO");
    }

    static void Main(string[] args)
    {
        var queryCount = int.Parse(Console.ReadLine());
        for (var i = 0; i < queryCount; i++)
        {
            var inputText = Console.ReadLine();
            SeparateNumbers(inputText);
        }
    }

    private static bool IsFirstCharZero(string textPart)
    {
        return textPart[0] == '0' ? true : false;
    }

    private static bool IsItLargestNDigitNumber(string textPart, int numberWidth)
    {
        var isLargest = true;
		for (var i = 0; i < textPart.Length; i++)
		{
			if (textPart[i] != '9')
			{
				isLargest = false;
				break;
			}
		}
		return isLargest;
    }
}