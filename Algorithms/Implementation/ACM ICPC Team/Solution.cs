/*
         Problem: https://www.hackerrank.com/challenges/acm-icpc-team/problem
         C# Language Version: 6.0
         .NET Framework Version: 4.7
         Tool Version : Visual Studio Community 2017
         Thoughts (Key points in algorithm):
         - Basic idea is that we need to iterate through every possible combination of two attendees (i.e. in pairs). In that sense it starts being
            a Combinatorics problem (ⁿC₂). e.g. for four students 1,2,3,4 all possible combinations are (1,2),(1,3),(1,4),(2,3),(2,4),(3,4)
         - While iterating a given combination, see if the current pair has highest number of known courses among the pair of attendees iterated
           so far.
         - Also keep a count of pairs who had the highest number of known courses.
         - Every time you hit a new high then reset the count of pairs to 1.

         Gotchas/Caveats:
          - the maximum number of possible courses is 500 (which means 500 bit wide string for each attendee). So storing the topic 
          knowledge of students as a number and then performing bitwise OR on them is not practical. Maximum width in C# is 
          64 bit integers for Int64 data type.

         Time Complexity:  O(m * n^2) //O(n^2) is required to create all combinations. O(m) loop is required to count the known
                                        courses to either of attendees in a pair. Since the O(m) loop is nested at the innermost
                                        level so the complexity becomes O(m * n^2)
         Space Complexity: O(n) //Course values of each attendee need to be stored in memory to create all possible combinations.
        */
using System;

class Solution
{
    static void Main(string[] args)
    {
        var userInputSplits = Console.ReadLine().Split(' ');
        //no need to capture topic count. We can use string's length property instead.
        var attendeeCount = int.Parse(userInputSplits[0]);

        var maxTopic = 0;
        var maxTeamCount = 0;

        var attendeeTopicsData = new string[attendeeCount];
        for (int i = 0; i < attendeeCount; i++)
            attendeeTopicsData[i] = Console.ReadLine();

        //for n number of attendees, this loop runs n(n-1)/2 times i.e. sum of first n-1 natural numbers
        //this makes the algorithm O(n^2)
        for (int i = 0; i < attendeeCount; i++)
        {
            for (int j = i + 1; j < attendeeCount; j++)
            {
                //counting of common courses again involves traversing the entire string m times (total number of topics/subjects).
                //looping inside CountKnownTopicsToBothAttendee method bumbps up the time complexity to O(m * n^2)
                var knownTopicsToBoth = CountKnownTopicsToBothAttendee(attendeeTopicsData[i], attendeeTopicsData[j]);
                if (knownTopicsToBoth > maxTopic)
                {
                    maxTopic = knownTopicsToBoth;
                    maxTeamCount = 1;
                }
                else if (knownTopicsToBoth == maxTopic)
                    maxTeamCount++;
            }
        }
        Console.WriteLine(maxTopic);
        Console.WriteLine(maxTeamCount);
    }

    private static int CountKnownTopicsToBothAttendee(string knownTopicsAttendee1, string knownTopicsAttendee2)
    {
        var count = 0;
        var CourseKnownFlag = '1';
        for (var courseIndex = 0; courseIndex < knownTopicsAttendee1.Length; courseIndex++)
        {
            if (knownTopicsAttendee1[courseIndex] == CourseKnownFlag || knownTopicsAttendee2[courseIndex] == CourseKnownFlag)
                count++;
        }
        return count;
    }
}