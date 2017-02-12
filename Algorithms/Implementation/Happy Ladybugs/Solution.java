//Problem: https://www.hackerrank.com/challenges/happy-ladybugs
//Java 8
/*
number of ladybugs
number of swap spaces

if we dont have at least 2 of ever color
    NO

if no _ then
    NO
    aabbyy

we have 2 or more and at least 1 _
    YES
    
example:
ab_bgybgayryrbg
abb_gybgayryrbg
abbggybgayryrb_
abbggy_gayryrbb
abbgg_ygayryrbb
abbgggy_ayryrbb
abbgggyya_ryrbb
abbgggyy_aryrbb
abbgggyyyar_rbb
abbgggyyya_rrbb

example:
_bbgggyyyaarrbbr
bbbgggyyyaarrb_r
bbbgggyyyaarr_br
bbbgggyyyaarrrb_
_bbgggyyyaarrrbb



find frequencies of all letters

if all frequencies are >= 2 and a _ is present
    YES
else if they are >= 2 and no _ is present
    if it is already ordered
        YES
    else
        NO
else
    NO

*/



import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int Q = in.nextInt();
        
        tests:
        for(int a0 = 0; a0 < Q; a0++){
            int n = in.nextInt();
            String b = in.next();
            
            HashMap<Character, Integer> colorFreq = new HashMap<>();
            
            //Find frequencys of each Letter
            for(int i = 0; i < b.length(); i++)
            {
                Character letter = (Character) b.charAt(i);
                if(colorFreq.containsKey(letter))
                {
                    colorFreq.put(letter, colorFreq.get(letter)+1);
                }
                else
                {
                    colorFreq.put(letter, 1);
                }
            }
            
            //NO if we dont have at least 2 of ever color
            for(Map.Entry<Character,Integer> frequency : colorFreq.entrySet())
            {                
                if(frequency.getValue() < 2 && !frequency.getKey().equals((Character)'_'))
                {
                    System.out.println("NO");
                    continue tests;
                }
            }
            
            //If it has no _ we must check if it is already in order 
            if(!colorFreq.containsKey('_'))
            {
                int count = 0;
                char last = b.charAt(0);
                for(int i = 0; i < b.length(); i++)
                {
                    char curr = b.charAt(i);
                    
                    if(curr == last)
                    {
                        count++;
                    }
                    else
                    {
                        if(count < 2)
                        {
                            System.out.println("NO");
                            continue tests;
                        }
                        else{count = 1;}
                    }
                    last = curr;
                }
                System.out.println("YES");
            }
            else //It has an _ so it is YES
            {
                System.out.println("YES");
            }
        }
    }
}
