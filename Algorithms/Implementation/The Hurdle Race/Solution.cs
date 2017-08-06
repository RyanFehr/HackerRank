/*
 Problem: https://www.hackerrank.com/challenges/the-hurdle-race/problem
 C# Language Version: 6.0
 .Net Framework Version: 4.5.2
 Thoughts :
 1. Let the initial jumping power of video game character be initPower. Set initPower to input received from user.
 2. Get the height of highest hurdle. Let's call it maxHurdleHeight.
 3. If maxHurdleHeight is less than or equal to initPower then print 0 
 4. If maxHurdleHeight is greater than initPower then print the difference between maxHurdleHeight and initialJumpPower

 Time Complexity:  O(n)
 Space Complexity: O(1)
        
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
            var tokens_n = Console.ReadLine().Split(' ');
            var initialJumpPower = Convert.ToInt32(tokens_n[1]);
            var height_temp = Console.ReadLine().Split(' ');
            var heightOfHurdles = Array.ConvertAll(height_temp, Int32.Parse);
            var maxHurdleHeight = heightOfHurdles.Max();
            if (maxHurdleHeight <= initialJumpPower)
                Console.WriteLine(0);
            else
                Console.WriteLine(maxHurdleHeight - initialJumpPower);
    }
}
