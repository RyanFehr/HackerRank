/*
         Problem: https://www.hackerrank.com/challenges/palindrome-index/problem
         C# Language Version: 6.0
         .Net Framework Version: 4.7
         Tool Version : Visual Studio Community 2017
         Thoughts (Key points in algorithm):
            - Idea to solve this problem is by looking at it from both ends just like you would while checking for the string 
            being a palindrome. 
            - When first inequality occurs remove the right unequal element and check whether it is a palindrome or not. If
            it is a palindrome then right index is the answer.
            e.g. the string aaab. You take two pointers at start and end to check palindrome
                    ▼  ▼
                    aaab
                    First mismatch occurs when first pointer is at index 0 and other pointer is at index 3. So remove the character
                    at index 3 and check the remaining string "aaa" if it is palindrome or not. It is, so 3 is the answer.
            - If the substring is not a palindrome then remove the left unequal element and check whether the remaining string
            is a palindrome or not. If it is a palindrome then left index is the answer.
            - In all other cases print -1. Either it is already a palindrome or palindrome is not possible by removing only one character.

         Gotchas:
          <None>

         Time Complexity:  O(n) //actually it is O(2n + c) ~ O(n). In worse case we might have to check the palindrome of
                                //entire string 2 times.  Each palindrome checking loop runs n/2 times.
         Space Complexity: O(n) //we need to store the input string in memory to process it.
                
        */
using System;

class Solution
{
    static void Main(String[] args)
    {
        var queryCount = int.Parse(Console.ReadLine());
            while (queryCount-- != 0)
            {
                var s = Console.ReadLine();
                var i = 0;
                var j = s.Length - 1;
                while (s[i] == s[j] && i++ < j--)
                ;

                if (i < j)
                {
                    //remove the mismatching right element and see if remaining string is still a palindrome
                    var sLeft = s.Remove(j, 1);
                    if (CheckPalindrome(sLeft))
                        Console.WriteLine(j);
                    else
                    {
                        //remove the mismatching left element and see if remaining string is still a palindrome
                        var sRight = s.Remove(i, 1);
                        if (CheckPalindrome(sRight))
                            Console.WriteLine(i);
                        else
                            Console.WriteLine("-1");
                    }
                }
                else
                    Console.WriteLine("-1");
            }
    }
    
    private static bool CheckPalindrome(string inputText)
        {
            var isPalindrome = true;
            for (var j = 0; j < inputText.Length / 2; j++)
            {
                if (inputText[j] != inputText[inputText.Length - j - 1])
                {
                    isPalindrome = false;
                    break;
                }
            }
            return isPalindrome;
        }
}