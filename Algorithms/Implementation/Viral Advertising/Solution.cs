/*
Problem: https://www.hackerrank.com/challenges/strange-advertising/problem
C# Language Version: 6.0
.Net Framework Version: 4.5.2
Thoughts :

1. Let the number of days for advertisement strategy runs be n.
2. Let total advertisement likes in n days be l. Set l = 0.
3. Let people who received advertisement on day 1 by m. Set m = 5
4. Start a loop which run n times with below steps in each iteration:
    4.1 Set l = l + floor(m/2)
    4.2 m = floor(m/2)*3
5. Print l


Time Complexity:  O(n) 
Space Complexity: O(1) 

*/

using System;

class Solution
{
    static void Main(String[] args)
    {
        var numberOfDays = int.Parse(Console.ReadLine());
        var totalLikes = 0D;
        var AdShareCount = 5.0;
        for (int i = 0; i < numberOfDays; i++)
        {
            totalLikes += Math.Floor(AdShareCount / 2);
            AdShareCount = Math.Floor(AdShareCount / 2) * 3;
        }
        Console.WriteLine(totalLikes);
    }
}