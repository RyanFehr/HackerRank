/*
    Problem: https://www.hackerrank.com/challenges/sock-merchant/problem
    C# Language Version: 6.0
    .Net Framework Version: 4.5.2
    Thoughts :
    1. Take the input array containing colors (number coded) of n socks in the pile.
    2. Initialize a counter named "pairsFound" with 0.
    3. Initialize a dictionary named "sockColorHash" which will store color coded number of a sock as key.
    3. Start iterating the socks pile array. 
    4.1 Let the current socks color be k.
    4.2 If k key is not present in sockColorHash dictionary then add it into the dictionary with value 1.
    4.3 If k key is present in sockColorHash dictionary then remove it into the dictionary and increment
        pairsFound counter by 1.
    5. Print pairsFound.

    Time Complexity:  O(n) //we have to iterate the socks pile array only once in a loop.
    Space Complexity: O(n) //only one dynamically allocated dictionary dependent on input array size.

*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int sockMerchant(int[] socksPile)
    {
        var pairsFound = 0;
        var sockColorHash = new Dictionary<int, int>();

        foreach (var sock in socksPile)
        {
            if (sockColorHash.ContainsKey(sock))
            {
                pairsFound++;
                sockColorHash.Remove(sock);
            }
            else
                sockColorHash.Add(sock, 1);
        }
        return pairsFound;
    }

    static void Main(String[] args) {
        Console.ReadLine();
        var ar_temp = Console.ReadLine().Split(' ');
        var ar = Array.ConvertAll(ar_temp, Int32.Parse);
        var result = sockMerchant(ar);
        Console.WriteLine(result);
    }
}
