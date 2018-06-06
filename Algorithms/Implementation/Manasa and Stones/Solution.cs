/*
         Problem: https://www.hackerrank.com/challenges/manasa-and-stones/problem
         C# Language Version: 7.0
         .Net Framework Version: 4.7
         Tool Version : Visual Studio Community 2017
         Thoughts :
         Basic t
         I'm putting here a simple solution to understand for case # 1:
         n = 4
         a = 10
         b = 100

         Few things to note:
         - End sum for last stone is independent of ordering of differences. Combination will matter to produce unique values for
            last stone
         - Since we've to get the sum in increasing order so always start with the smaller difference. 

         
         The idea is to start with assuming smaller difference for all stones on the treasure trail as below:

         0,10,10,10 ---resulting stone numbers ----> 0,10,20,30

         Now start replacing the bigger number one by one

         0,10,10,100 ---resulting stone numbers-----> 0,10,20,220
         0,10,100,100 ---resulting stone numbers-----> 0,10,110,210
         0,100,100,100 ---resulting stone numbers-----> 0,100,200,300

         I implemented the above logic using a simple for loop with special handling for the case when both differences are equal i.e. a == b

         Time Complexity:  O(n)
         Space Complexity: O(1) //no additional space is required.
                
*/
using System;

class Solution
{
    static void Stones(int n, int a, int b)
    {
        if (a == b)
        {
            Console.Write((n - 1) * a);
            return;
        }

        if (b < a)
        {
            var temp = b;
            b = a;
            a = temp;
        }

        for (int i = 0; i < n; i++)
            Console.Write((a * (n - 1 - i) + b * i) + " ");
    }

    static void Main(String[] args)
    {
        var testCases = int.Parse(Console.ReadLine());
        for (int a0 = 0; a0 < testCases; a0++)
        {
            var n = int.Parse(Console.ReadLine());
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            Stones(n, a, b);
            Console.WriteLine();
        }
    }
}
