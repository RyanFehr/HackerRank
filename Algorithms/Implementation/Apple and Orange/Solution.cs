/*
  Problem: https://www.hackerrank.com/challenges/apple-and-orange
  C# Language Version: 6.0
  .Net Framework Version: 4.7
  Tool Version : Visual Studio Community 2017
  Thoughts :
  1. Let house start and end positions be hs and he resrpectively.
  2. Let apple and orange tree positions be ta and to respectively.
  3. Let there be m apples and n oranges which fall from respective trees.
  4. Let the count of apples and oranges falling on the house be ca and co respectively. Set ca and co to 0.
  5. Start iterating the falling positions of m apples in a loop:
     5.1 Let the falling position of current apple be fa.
     5.2 Let effective falling position of current apple on x-axis be ea. Set ea = ta + fa.
     5.3 if ea is lying between hs and he (both inclusive) then increment ca by 1.
     5.4 Repeat steps 5.1 through 5.3 untill all apples have been iterated.
  6. Start iterating the falling positions of n oranges in a loop:
     6.1 Let the falling position of current orange be fo.
     6.2 Let effective falling position of current orange on x-axis be eo. Set eo = to + fo.
     6.3 if eo is lying between hs and he (both inclusive) then increment co by 1.
     6.4 Repeat steps 6.1 through 6.3 untill all oranges have been iterated.
  7. Print ca on new line.
  8. Print co on new line.

  Time Complexity:  O(m+n) //there are two separate loops which run m and n times. Since the values of m and n are independent
                     of each other so time complexity becomes order O(m+n)
  Space Complexity: O(n) //In C# you have to read in the entire console line at a time(size n), because it does not have a way to iteratively read in space delimited input
 */

using System;

class Solution
{
    static void Main(String[] args)
    {
        var applesFallingOnHouse = 0;
        var orangesFallingOnHouse = 0;

        var tokens_s = Console.ReadLine().Split(' ');
        var houseStart = int.Parse(tokens_s[0]);
        var houseEnd = int.Parse(tokens_s[1]);

        var tokens_a = Console.ReadLine().Split(' ');
        var appleTreePosition = int.Parse(tokens_a[0]);
        var OrangeTreePosition = int.Parse(tokens_a[1]);

        //No need to capture number of apples and oranges as I use foreach loop to iterate them.
        Console.ReadLine();

        var apple_temp = Console.ReadLine().Split(' ');
        var fallingApples = Array.ConvertAll(apple_temp, Int32.Parse);
        var orange_temp = Console.ReadLine().Split(' ');
        var fallingOranges = Array.ConvertAll(orange_temp, Int32.Parse);

        foreach (var fallingApple in fallingApples)
        {
            var fallingApplePosition = appleTreePosition + fallingApple;
            if (fallingApplePosition >= houseStart && fallingApplePosition <= houseEnd)
                ++applesFallingOnHouse;
        }

        foreach (var fallingOrange in fallingOranges)
        {
            var fallingOrangePosition = OrangeTreePosition + fallingOrange;
            if (fallingOrangePosition >= houseStart && fallingOrangePosition <= houseEnd)
                ++orangesFallingOnHouse;
        }

        Console.WriteLine(applesFallingOnHouse);
        Console.WriteLine(orangesFallingOnHouse);
    }
}
