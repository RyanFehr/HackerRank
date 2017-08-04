/*
    Problem: https://www.hackerrank.com/challenges/electronics-shop
    Language: C# 
    Thoughts:
        1. Let Monica has total money MTotal.
        2. Let maximum money spendable on electronics be MaxMoneySpendable. Initialize it to -1.
        3. Consider ArrayKeyboardPrices and ArrayDrivePrices.
        4. Sort ArrayKeyboardPrices in descending order.
        5. Sort ArrayDrivePrices in ascending order.
        6. Start iterating the elements in the sorted ArrayKeyboardPrices. Let the keyboard price being iterated is kbCurrent.
        7. For kbCurrent start iterating the elements of sorted ArrayDrivePrices.
            - let the drive price being iterated is driveCurrent.
            - if sum of driveCurrent and kbCurrent is greater than MTotal then stop iterating sorted ArrayDrivePrices
            - if sum of driveCurrent and kbCurrent is less than or equal to MTotal 
                then set MaxMoneySpendable to  sum of driveCurrent and kbCurrent
                and move to next element in sorted ArrayDrivePrices
        8. Repeat step 7 for all elements of sorted ArrayKeyboardPrices
        9. Print MaxMoneySpendable.

        Time Complexity:  
        Worst case : O(n^2)
        Best case : O(nlog n)
        Space Complexity: O(1)        
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {
        static int getMoneySpent(int[] keyboards, int[] drives, int totalMoneyAvailable)
        {
            var sortedKeyboardPrices = from keyboard in keyboards
                                 orderby keyboard descending
                                 select keyboard;
            var sortedDrivePrices = from drive in drives
                              orderby drive ascending
                              select drive;
            //default if not able to purchase anything
            var maxMoneySpendable = -1;

            foreach (var keyboard in sortedKeyboardPrices)
            {
                foreach (var drive in sortedDrivePrices)
                {
                    if (keyboard + drive <= totalMoneyAvailable)
                    {
                        if (keyboard + drive > maxMoneySpendable)
                            maxMoneySpendable = keyboard + drive;
                    }
                    else
                        break;
                }
            }
            return maxMoneySpendable;
        }

    static void Main(String[] args) {
        string[] tokens_s = Console.ReadLine().Split(' ');
        int s = Convert.ToInt32(tokens_s[0]);
        string[] keyboards_temp = Console.ReadLine().Split(' ');
        int[] keyboards = Array.ConvertAll(keyboards_temp,Int32.Parse);
        string[] drives_temp = Console.ReadLine().Split(' ');
        int[] drives = Array.ConvertAll(drives_temp,Int32.Parse);
        //  The maximum amount of money she can spend on a keyboard and USB drive, or -1 if she can't purchase both items
        int moneySpent = getMoneySpent(keyboards, drives, s);
        Console.WriteLine(moneySpent);
    }
}
