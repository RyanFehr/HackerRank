/*
         Problem: https://www.hackerrank.com/challenges/append-and-delete/problem
         C# Language Version: 6.0
         .NET Framework Version: 4.7
         Tool Version : Visual Studio Community 2017
         Thoughts (Key points in algorithm):
         We need to handle a number of test cases which is possible between source and target string. There are
         several cases where we need to print Yes as below:
             - k >= |s| + |t|
             - case when s could be prefix of t
             - case when t could be prefix of s
             - case when tail difference between s and t is exactly equal to k

         Gotchas/Caveats:
          <None>

         Time Complexity:  O(min(|s|,|t|) //a loop is there which runs through the length of smaller string in worst case.
         Space Complexity: O(|s| + |t|) //Both input strings need to be stored in program memory for comparison operations.
*/

using System;

class Solution
{
    static void Main(string[] args)
    {
        var initialString = Console.ReadLine();
        var finalString = Console.ReadLine();
        var k = int.Parse(Console.ReadLine());

        if (k >= initialString.Length + finalString.Length)
            Console.WriteLine("Yes");
        else
        {
            var remainingLength1 = initialString.Length;
            var remainingLength2 = finalString.Length;
            for (int i = 0; i < initialString.Length; i++)
            {
                if (i < finalString.Length && initialString[i] == finalString[i])
                {
                    remainingLength1--;
                    remainingLength2--;
                }
                else
                    break;
            }


            if (remainingLength2 == 0)
            {
                /*
                 Handling of case: When target string is already a prefix of the initial string.
                 aaaaaaaaaa
                 aaaaa
                 7
                 */
                if (k >= remainingLength1 && (k - remainingLength1) % 2 == 0)
                    Console.WriteLine("Yes");
                else
                    Console.WriteLine("No");
            }
            else if (remainingLength1 == 0)
            {
                /*
                 Handling of case: When initial string is a prefix of the target string.
                 zzzzz
                 zzzzzzz
                 4
                 */
                if (k >= remainingLength2 && (k - remainingLength2) % 2 == 0)
                    Console.WriteLine("Yes");
                else
                    Console.WriteLine("No");
            }
            else if (remainingLength1 + remainingLength2 == k)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}