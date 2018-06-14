/*
  Problem: https://www.hackerrank.com/challenges/lisa-workbook/problem
  C# Language Version: 7.0
  .Net Framework Version: 4.7
  Tool Version : Visual Studio Community 2017
  Thoughts :
  1. Let the question of all arrays are stored in an array arr.
  2. Let the maximum number of questions possible on any page in the book be maxQ.
  3. Let the count of special questions in the book be sq. Initialize specialQ to 0.
  4. Let the current page number of the book be currP. Initialize currP to 0.
  5. Start a loop to iterate through elements of arr:
     5.1 Let the number of question in current chapter being iterated be n.
     5.2 Let the starting question number of any page for current chapter be qStart. Initialize qStart to 1-maxQ.
     5.3 Let the ending question number of any page for current chapter be be qEnd. Initialize qEnd to 0.
     5.4 Start a loop:
         5.4.1 increment currP by 1.
         5.4.2 increment qStart by maxQ.
         5.4.3 if n >= maxQ then increment qEnd by maxQ.
         5.4.4 if n < maxQ then increment qEnd by n.
         5.4.5 If currP is in the range [qStart,qEnd] then increment specialQ by 1.
         5.4.6 Decrement n by maxQ.
         5.4.7 If n <= 0 then break the loop.
         5.4.8 Continue the loop and keep repeating steps from 5.4.1 through 5.4.7 until loop doesn't break.
     5.5 Keep repeating the steps 5.1 through 5.4 untill all the chapters present in arr don't get processed.
 6. Print specialQ on console.

  Time Complexity:  O(n) //There is one for loop. The number of times nested while loop runs will be very random as it has no 
                         direct relationship with number of chapters in the book. So I've ignored the nested inner loop while calculating time complexity.
  Space Complexity: O(n) //Chapterwise problem counts have been stored in array for later processing. 
                     Space complexity doesn't match the optimal O(1) solution as in C#, you have to read the entire console line at a time (size n).
                     C# doesn't support to iteratively read in space delimited input on the go. If there had been a Scanner like class which exists in Java 
                     then it would have been possible to accomplish the same algorithm in O(1) space complexity.
  Optimal Space Complexity : O (1)
 */
using System;

class Solution
{

    static int Workbook(int maxQuestionsPerPage, int[] arr)
    {
        var currPageNumber = 0;
        var specialProblems = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            var currChapterQuesCount = arr[i];
            var questionStart = 1 - maxQuestionsPerPage;
            var questionEnd = 0;
            do
            {
                currPageNumber++;
                questionStart += maxQuestionsPerPage;
                if (currChapterQuesCount >= maxQuestionsPerPage)
                    questionEnd += maxQuestionsPerPage;
                else
                    questionEnd += currChapterQuesCount;

                if (currPageNumber >= questionStart && currPageNumber <= questionEnd)
                    specialProblems++;

                currChapterQuesCount -= maxQuestionsPerPage;
            } while (currChapterQuesCount > 0);
        }
        return specialProblems;
    }

    static void Main(String[] args)
    {
        var tokens_n = Console.ReadLine().Split(' ');
        //No need to capture the size of array. I use array's length property instead.
        var maxQuestionsPerPage = int.Parse(tokens_n[1]);
        var arr_temp = Console.ReadLine().Split(' ');
        var arr = Array.ConvertAll(arr_temp, Int32.Parse);
        var specialProblemsCount = Workbook(maxQuestionsPerPage, arr);
        Console.WriteLine(specialProblemsCount);
    }
}
