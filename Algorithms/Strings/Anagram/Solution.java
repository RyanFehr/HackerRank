//Problem: https://www.hackerrank.com/challenges/anagram
//Java 8
/*
Initial Thoughts:
Get frequency of first and second half
Count the changes second half needs to become first half

Time complexity: O(n)   //Time equivalent to input size
Space complexity: O(1)  //The alphabet is limited to 26 char so maps have a constant size


*/
import java.io.*;
import java.util.*;

public class Solution {

    public static void main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution. */
        Scanner input = new Scanner(System.in);
        int T = input.nextInt();
        input.nextLine();
        
        tests:
        for(int t = 0; t < T; t++)
        {
            String s = input.nextLine();
            
            if(s.length() % 2 == 1)
            {
                System.out.println(-1); continue tests;
            }
            
            
            Map<Character,Integer> firstHalf = new HashMap<>();
            Map<Character,Integer> secondHalf = new HashMap<>();
            
            //Get frequency of chars in first half
            for(int i = 0; i < s.length()/2; i++)
            {
                if(firstHalf.containsKey(s.charAt(i)))
                    firstHalf.put(s.charAt(i), firstHalf.get(s.charAt(i)) + 1);
                else
                    firstHalf.put(s.charAt(i), 1);
            }
                
            //Get frequency of chars in second half
            for(int i = s.length()/2; i < s.length(); i++)
            {
                if(secondHalf.containsKey(s.charAt(i)))
                    secondHalf.put(s.charAt(i), secondHalf.get(s.charAt(i)) + 1);
                else
                    secondHalf.put(s.charAt(i), 1);
            }
            int operations = 0;
            
            //Iterate through second half determining what needs to switch to match it
            for(Map.Entry<Character,Integer> letter : secondHalf.entrySet())
            {
                
                int f2 = letter.getValue();
                int f1 = (firstHalf.get(letter.getKey()) != null) ? firstHalf.get(letter.getKey()) : 0;
                
                //This is when there are not enough chars in the first half to match those in the second half
                if(f2 > f1)
                    operations += (f2 - f1);  
                
                
            }
            System.out.println(operations);
        }
    }
}