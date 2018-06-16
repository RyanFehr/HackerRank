/*
        Problem: https://www.hackerrank.com/challenges/day-of-the-programmer/problem
        C# Language Version: 6.0
        .Net Framework Version: 4.7
        Tool Version : Visual Studio Community 2017
        Thoughts :
           We need special handling for Gregorian calendar and Julian calendar based on input year.
           It is pretty straight forward to reach to correct answer if we follow the information given in the problem.
           Since it is a O(1) complexity problem so not much optimization is possible.

        Time Complexity:  O(1) //There are no loops.
        Space Complexity: O(1) //number of dynamically allocated variables remain constant for any input.

*/

using System;

class Solution
{
    static string Solve(int year)
    {
        //256th Day
        var programmerDate = "";
        if (year >= 1919)
            programmerDate = GetProgrammerDateForGregorianCalendar(year);
        else if (year <= 1917)
        {
            programmerDate = GetProgrammerDateForJulianCalendar(year);
        }
        else
        {
            //gregorian switch year
            programmerDate = "26.09.1918";// GetProgrammerDateForCalendarSwitchYear1918(year);
        }

        return programmerDate;
    }

    private static string GetProgrammerDateForCalendarSwitchYear1918(int year)
    {
        //1918 was a gregorian calendar after 1918 (it wasn't a leap year)
        var daysTillAug = 230;//  31 + 15 + 31 + 30 + 31 + 30 + 31 + 31
        var programmerDateInSeptember = 0;
        programmerDateInSeptember = 256 - daysTillAug;
        var dateWithFormat = programmerDateInSeptember + ".09." + year.ToString();
        return dateWithFormat;
    }

    private static string GetProgrammerDateForJulianCalendar(int year)
    {
        var daysTillAugInLeapYear = 244; //31 + 29 + 31 + 30 + 31 + 30 + 31 + 31
        var daysTillAugInNonLeapYear = 243; //31 + 28 + 31 + 30 + 31 + 30 + 31 + 31
        var programmerDateInSeptember = 0;
        programmerDateInSeptember = IsJulianLeapYear(year) ? 256 - daysTillAugInLeapYear : 256 - daysTillAugInNonLeapYear;
        var dateWithFormat = programmerDateInSeptember + ".09." + year.ToString();
        return dateWithFormat;
    }

    private static bool IsJulianLeapYear(int year)
    {
        if (year % 4 == 0)
            return true;

        return false;
    }

    private static string GetProgrammerDateForGregorianCalendar(int year)
    {
        var daysTillAugInLeapYear = 244; //31 + 29 + 31 + 30 + 31 + 30 + 31 + 31
        var daysTillAugInNonLeapYear = 243; //31 + 28 + 31 + 30 + 31 + 30 + 31 + 31
        var programmerDateInSeptember = 0;

        programmerDateInSeptember = IsGregorianLeapYear(year) ? 256 - daysTillAugInLeapYear : 256 - daysTillAugInNonLeapYear;
        var dateWithFormat = programmerDateInSeptember + ".09." + year.ToString();
        return dateWithFormat;
    }

    private static bool IsGregorianLeapYear(int year)
    {
        if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
            return true;

        return false;
    }

    static void Main(String[] args)
    {
        var year = int.Parse(Console.ReadLine());
        var result = Solve(year);
        Console.WriteLine(result);
    }
}
