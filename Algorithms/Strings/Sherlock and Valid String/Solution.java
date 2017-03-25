//Problem: https://www.hackerrank.com/challenges/sherlock-and-valid-string
//Java 8
/*
Initial Thoughts:
Get every chars' frequency 

If there are more than two different frequencies
    NO
if 1 frequency 
    YES
if 2 frequency
    if 1 occurs only once and frequency is 1
        yes
    else
        if their difference 1 and one has frequency 1
            yes
        else
            no

examples:

abcde       -> Y
a           -> Y
aabb        -> Y
aaaabbbbc   -> Y
aaaabbbbcd  -> N
aabbcd      -> N

Time Complexity: O(n) //We have to look at every char
Space Complexity: O(n) //We store frequencies in a Hashmap

*/


import java.io.*;
import java.util.*;

public class Solution {

    public static void main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution. */
        Scanner input = new Scanner(System.in);
        String s = input.nextLine();
        
        Map<Character, Integer> frequencies = new HashMap<>();
        
        for(char letter : s.toCharArray())
        {
            if(frequencies.containsKey(letter))
                frequencies.put(letter, frequencies.get(letter) + 1);
            else
                frequencies.put(letter, 1);
        }
        
        
        
        Set<Integer> st = new HashSet<>();
        for(int freq : frequencies.values())
        {
            st.add(freq);
        }
        
        if(st.size() > 2)//More than 2 frequencies
            System.out.println("NO");
        else if(st.size() == 1)
            System.out.println("YES");
        else//2 different frequencies
        {
            int f1 = 0;
            int f2 = 0;
            int f1Count = 0;
            int f2Count = 0;
            int i = 0;
            for(int n : st)
            {
                if(i == 0) f1 = n;
                else f2 = n;
                i++;
            }
            
            for(int freq : frequencies.values())
            {
                if(freq == f1) f1Count++;
                if(freq == f2) f2Count++;
            }
            
            
            
            if((f1 == 1 && f1Count == 1 ) || (f2 == 1 && f2Count == 1 ))
                System.out.println("YES");
            else if ((Math.abs(f1 - f2)  == 1) && (f1Count == 1 || f2Count == 1))
                System.out.println("YES");
            else
                System.out.println("NO");
        }
    }
}