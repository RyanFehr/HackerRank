/*
    Problem: https://www.hackerrank.com/challenges/between-two-sets
    C# Language Version: 6.0
    .Net Framework Version: 4.7
    Tool Version : Visual Studio Community 2017
    Thoughts :
    1. Get the highest number present in set A. Let's call it maxA.
    2. Get the lowest number present in set B. Let's call it minB.
    3. Let the count of common Xs between set A and B be c. Initially set it to 0.
    4. Initialize a counter, co to 1.
    5. Run a loop while maxA <= minB
        5.1 Initialize a boolean, b to true.
        5.2 check if even a single element in set A is found which is not a factor of maxA then set b to false.
        5.3 if b is true then check if even a single element in set B is found for which maxA is not a factor then set b to false.
        5.4 If b is true then increment c by 1.
        5.5 increment co by 1.
        5.6 Set maxA to maxA * co.
        5.7 Continue iterating the loop until the termination condition is met.
    6. print c on a new line.

    Time Complexity:  O(x(n+m)) //where x = (max(m) - min(n))/min(n)
                                //Little tricky as the while loop is not purely iterative incrementing by 1 each time.
                            
    Space Complexity: O(1) //number of dynamically allocated variables remain constant for any number of elements in set A or B.

*/
using System;
using System.Linq;

class Solution
{
    static void Main(String[] args)
    {
        //No need to capture number of elments in set A and B as I use foreach loop to iterate them.
        Console.ReadLine();
        var a_temp = Console.ReadLine().Split(' ');
        var setA = Array.ConvertAll(a_temp, Int32.Parse);
        var b_temp = Console.ReadLine().Split(' ');
        var setB = Array.ConvertAll(b_temp, Int32.Parse);
        int total = getTotalX(setA, setB);
        Console.WriteLine(total);
    }

    static int getTotalX(int[] a, int[] b)
    {
        var totalXs = 0;
        var maximumA = a.Max(); //Time-complexity O(n)
        var minimumB = b.Min(); //Time-complexity O(m)
        var counter = 1;
        var multipleOfMaxA = maximumA;

        while (multipleOfMaxA <= minimumB)
        {
            var factorOfAll = true;

            foreach (var item in a) //Time complexity O(n)
            {
                if (multipleOfMaxA % item != 0)
                {
                    factorOfAll = false;
                    break;
                }
            }

            if (factorOfAll)
            {
                foreach (var item in b) //Time complexity O(m)
                {
                    if (item % multipleOfMaxA != 0)
                    {
                        factorOfAll = false;
                        break;
                    }
                }
            }

            if (factorOfAll)
                totalXs++;

            counter++;
            multipleOfMaxA = maximumA * counter; //Here counter is the x factor which contributes to O(x(n+m)) complexity.
        }
        return totalXs;
    }


}