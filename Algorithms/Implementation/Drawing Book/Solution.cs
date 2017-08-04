/*
         Problem: https://www.hackerrank.com/challenges/drawing-book/problem
         C# Language Version: 6.0
         .Net Framework Version: 4.5.2
         Thoughts :
         1. Let total number of pages in the book be totalPagesInBook and the page number we want to open is targetPageNumber.
         2. Let the minimum number of pages which are to be turned to reach targetPageNumber is minimumPagesToTurn.
         3. Set minimumPagesToTurn to 0
         4. There are three cases in which user will not have to turn even a single page
            - If targetPageNumber is 1 OR
            - If targetPageNumber is equal to totalPagesInBook OR
            - If totalPagesInBook is an odd number and targetPageNumber is totalPagesInBook-1
            If either of the above three conditions are met then jump to step 7.
         5. If totalPagesInBook is an even number then
            - if targetPageNumber is less than or equal to half of totalPagesInBook then starting from front will be beneficial.
              Set minimumPagesToTurn to half of targetPageNumber.
            - otherwise starting from end will be beneficial.
              Set minimumPagesToTurn to half of difference between totalPagesInBook and targetPageNumber. If the operation
              results in a decimal value then round it off to its nearest higher integer.
         6. If totalPagesInBook is an odd number then
            - If targetPageNumber is the exact median of totalPagesInBook and totalPagesInBook in book
                is exacly one less than the nearest multiple of 4 then starting from end will be beneficial.
                Set minimumPagesToTurn to half of difference of totalPagesInBook and targetPageNumber.
            - If targetPageNumber is less than, equal to or one more than half of totalPagesInBook then starting from front will be beneficial.
              Set minimumPagesToTurn to half of targetPageNumber.
            - otherwise starting from back will be beneficial.
              Set minimumPagesToTurn to half of difference between totalPagesInBook and targetPageNumber. 
          7. Print minimumPagesToTurn

         Time Complexity:  O(1)
         Space Complexity: O(1)
                
        */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int solve(int totalPagesInBook, int targetPageNumber){
        var minimumPagesToTurn = 0;

            if (targetPageNumber == 1 || targetPageNumber == totalPagesInBook)
                return minimumPagesToTurn;

            if (totalPagesInBook % 2 != 0 && targetPageNumber == totalPagesInBook - 1)
                return minimumPagesToTurn;


            if (totalPagesInBook % 2 == 0)
            {
                //even number of total pages e.g. 10
                if (targetPageNumber <= totalPagesInBook / 2)
                {
                    //start from front
                    minimumPagesToTurn = targetPageNumber / 2;
                }
                else
                {
                    //start from end
                    double d = ((double)(totalPagesInBook - targetPageNumber)) / 2;
                    minimumPagesToTurn = (int)Math.Ceiling(d);
                }
            }
            else
            {
                //total number of pages are odd

                //special handling for exactly middle number when total number of pages are like 3,7,11,15...and so on

                if (targetPageNumber == (totalPagesInBook/2)+1 && totalPagesInBook % 4 == 3)
                {
                    //this requires special handling as this median will be close to the end instead
                    minimumPagesToTurn = (totalPagesInBook - targetPageNumber) / 2;
                }
                else
                {
                    if (targetPageNumber <= ((totalPagesInBook / 2) + 1))
                    {
                        //start from front
                        minimumPagesToTurn = targetPageNumber / 2;
                    }
                    else
                    {
                        //start from end
                        minimumPagesToTurn = (totalPagesInBook - targetPageNumber) / 2;
                    }
                }

            }
            return minimumPagesToTurn;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        int p = Convert.ToInt32(Console.ReadLine());
        int result = solve(n, p);
        Console.WriteLine(result);
    }
}
