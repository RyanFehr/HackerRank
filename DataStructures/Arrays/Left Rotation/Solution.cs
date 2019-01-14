using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.HackerRank
{
    /*
        Problem: https://www.hackerrank.com/challenges/array-left-rotation/problem
        C# Language Version: 6.0
        .NET Framework Version: 4.7
        Tool Version : Visual Studio Community 2015
        Thoughts (Key points in algorithm) :
        1. Take input strings in an string array 
        2. Split first input strings and get no of intergers in array and no of left rotaion to perform.
        3. Split second input string and print values of this splitted array starting from index = no of left rotation to last
        4. Print splitted values of above array starting from index 0 to left rotation-1
        
        Gotchas:
        I haven't converted strings in integer before printing them.

        Time Complexity:  O(n) //looping throgh the splitted array
        Space Complexity: O(n) //initializing an array that stores splitted string elements.
    */
    class LeftRotation
    {
        public static void Execute()
        {
            var inputLine1 = Console.ReadLine();
            var inputLine2 = Console.ReadLine();

            var inputSplitsLine1 = inputLine1.Split(' ');
            var arraylength = int.Parse(inputSplitsLine1[0]);
            var noOfLeftRotation = int.Parse(inputSplitsLine1[1]);

            var inputSplitsLine2 = inputLine2.Split(' ');
            for (var i = noOfLeftRotation; i < arraylength; i++)
                Console.Write("{0} ",inputSplitsLine2[i]);
            for(var i=0; i<noOfLeftRotation;i++)
                Console.Write("{0} ", inputSplitsLine2[i]);
            Console.ReadLine();
        }
    }
}
