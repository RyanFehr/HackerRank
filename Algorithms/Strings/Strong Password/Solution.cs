/*
        Problem: https://www.hackerrank.com/challenges/strong-password/problem
        C# Language Version: 6.0
        .Net Framework Version: 4.7
        Tool Version : Visual Studio Community 2017
        Thoughts :
        Keep iterating the input string untill
         - at least one digit is found
         - at least one lower case alphabet is found
         - at least one upper case alphabet is found
         - at least special character is found
         - at least 6 characters have been traversed

        In the end extra chars will be required depending upon each of the conditions (above mentioned) which is still false.

        Time Complexity:  O(n)
        Space Complexity: O(1) //number of dynamically allocated variables remain constant for any input.

*/
using System;

class Solution
{
    static void Main(string[] args)
    {
        var extraChars = 0;
        var digitOccured = false;
        var lowerCaseOccured = false;
        var upperCaseOccured = false;
        var specialCharsOccured = false;
        var desiredLength = 0;

        Console.ReadLine();
        var nextChar = Console.Read();


        while (nextChar != -1)
        {
            //C# v7 is currently not supported by hacker rank execution environment else a range based
            //switch case could've been used as below
            /*

            switch (nextChar)
            {
                case int n when (n >= 48 && n <= 57):
                    digitOccured = true;
                    break;
                case int n when (n >= 97 && n <= 122):
                    lowerCaseOccured = true;
                    break;
                case int n when (n >= 65 && n <= 90):
                    upperCaseOccured = true;
                    break;
                case 33: //"!"
                case 64: //"@"
                case 94: //"^"
                case 45: //"-"
                case int n when (n >= 35 && n <= 38): //#$%&
                case int n1 when (n1 >= 40 && n1 <= 43): //()*+
                    specialCharsOccured = true;
                    break;
                default:
                    break;
            }

            */
            if (nextChar >= 48 && nextChar <= 57)
                digitOccured = true;

            if (nextChar >= 97 && nextChar <= 122)
                lowerCaseOccured = true;

            if (nextChar >= 65 && nextChar <= 90)
                upperCaseOccured = true;


            if (nextChar == 33
               || nextChar == 64
               || nextChar == 94
               || nextChar == 45
               ) //!@^-
                specialCharsOccured = true;

            if (nextChar >= 35 && nextChar <= 38) //#$%&
                specialCharsOccured = true;


            if (nextChar >= 40 && nextChar <= 43) //()*+
                specialCharsOccured = true;

            desiredLength++;
            if (digitOccured && lowerCaseOccured && upperCaseOccured && specialCharsOccured && desiredLength >= 6)
                break;

            nextChar = Console.Read();
        }

        if (!digitOccured)
            extraChars++;

        if (!lowerCaseOccured)
            extraChars++;

        if (!upperCaseOccured)
            extraChars++;

        if (!specialCharsOccured)
            extraChars++;

        if (desiredLength + extraChars < 6)
            extraChars += 6 - extraChars - desiredLength;

        Console.WriteLine(extraChars);

    }
}