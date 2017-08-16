/*
Problem: https://www.hackerrank.com/challenges/save-the-prisoner/problem
C# Language Version: 6.0
.Net Framework Version: 4.5.2
Thoughts :
1. Let the id of the prisoner from whom the sweet distribution begins is i.
2. Let number of sweets to be distributed be n.
3. Let total number of prisoners be m.
4. Get the number of prisoners to be served starting from current value of i till the prisoner having highest prisoner Id. Let this number be p (= m - i + 1).
5. If n is greater than p then 
    5.1 set i to 1.
    5.2 set n to n - p
    5.3 set n to n % m. Here % is remainder operator.
6. If n is 0 then set i to m.
6. If n is not equal to 0 then set i to i + n -1
5. Print i

Time Complexity:  O(1)
Space Complexity: O(1)

*/

using System;
class Solution
{
    static int SaveThePrisoner(int numberOfPrisoners, int numberOfSweets, int prisonerId)
    {
        var remainingPrisonersBeforeEnd = numberOfPrisoners - prisonerId + 1;

        if (numberOfSweets > remainingPrisonersBeforeEnd)
        {
            prisonerId = 1;
            numberOfSweets -= remainingPrisonersBeforeEnd;
            numberOfSweets = numberOfSweets % numberOfPrisoners;
        }

        if (numberOfSweets == 0)
            prisonerId = numberOfPrisoners;
        else
            prisonerId += numberOfSweets - 1;

        return prisonerId;

    }

    static void Main(String[] args)
    {
        var t = int.Parse(Console.ReadLine());
        for (var a0 = 0; a0 < t; a0++)
        {
            var tokens_n = Console.ReadLine().Split(' ');
            var n = int.Parse(tokens_n[0]);
            var m = int.Parse(tokens_n[1]);
            var s = int.Parse(tokens_n[2]);
            var result = SaveThePrisoner(n, m, s);
            Console.WriteLine(result);
        }
    }
}
