//Problem: https://www.hackerrank.com/challenges/morgan-and-a-string
//Java 8 
/*
Initial thoughts:
Since we can only pull from the top of each 
letter stack each time, we simply need to just
compare the letters at the top of each stack

In each comparison we just need to choose the
letter that is lexicographically smaller than
the other and print it out and continue this 
until 1 of the stacks is empty.

If we have equivalent characters, we have to decide 
which one to pick

When they are equivalent, we choose the one from the 
stack that is overall lexicographically smaller
Read inline comments for better understanding of how
I handle this

Then if we have finished 1 string early we just need 
to add letters from the other stack to the end of the 
string we built

Time Complexity: O(|a|+|b|^2)   //We only view each letter once
Space Complexity: O(|a| + |b|)  //We store out output in a SB to speed up run time
*/

import java.io.*;
import java.util.*;

public class Solution {

    public static void main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution. */
        Scanner input = new Scanner(System.in);
        int t = input.nextInt();
        
        for(int a0 = 0; a0 < t; a0++)
        {
            StringBuilder s1 = new StringBuilder(input.next()); s1.append("z");//Denote end
            StringBuilder s2 = new StringBuilder(input.next()); s2.append("z");//Denote end
            StringBuilder output = new StringBuilder("");
            
            int i = 0, j = 0;//Index into each string
            while(i < s1.length() && j < s2.length())
            {
                ////////////Simple cases/////////////
                if(s1.charAt(i) < s2.charAt(j))
                {
                    output.append(s1.charAt(i));
                    i++;
                }
                else if(s1.charAt(i) > s2.charAt(j))
                {
                    output.append(s2.charAt(j));
                    j++;
                }
                //////////////////////////////////////
                
                
                
                ///////Characters are different///////
                else 
                {
                    if(s1.charAt(i) == 'z'){i++; j++; continue;}//End has been reached

                    
                    int startingI = i;
                    int startingJ = j;
                    
                    //Find the point at which their equality diverges
                    while(s1.charAt(i) == s2.charAt(j))
                    {
                        i++;
                        j++;
                        if(i >= s1.length() && j >= s2.length()) //They are the same string
                        {
                            i = startingI;
                            j = startingJ;
                            break;  
                        }
                        else if(i >= s1.length()) //String 1 is shorter than string 2
                        {
                            //We append all chars that are in a decreasing sequence 
                            ////////ex: gdbad would return gdba
                            char prev = s2.charAt(startingJ);
                            while(s2.charAt(startingJ) <= prev)
                            {
                                output.append(s2.charAt(startingJ));
                                prev = s2.charAt(startingJ);
                                startingI++;
                            }
                            i = startingI;
                            j = startingJ;
                        }
                        else if(j >= s2.length()) //String 2 is shorter than string 1
                        {
                            char prev = s1.charAt(startingI);
                            while(s1.charAt(startingI) <= prev)
                            {
                                output.append(s1.charAt(startingI));
                                prev = s1.charAt(startingI);
                                startingI++;
                            }
                            i = startingI;
                            j = startingJ;
                        }
                    }
                    
                    
                    //They are different strings
                    
                    //String 1 is lexicographically smaller than String 2
                    if(s1.charAt(i) <= s2.charAt(j))
                    {
                        char prev = s1.charAt(startingI);
                        while(s1.charAt(startingI) <= prev)
                        {
                            output.append(s1.charAt(startingI));
                            prev = s1.charAt(startingI);
                            startingI++;
                        }
                        i = startingI;
                        j = startingJ;
                    }
                    
                    //String 2 is lexicographically smaller than String 1
                    if(s1.charAt(i) > s2.charAt(j))
                    {
                        char prev = s2.charAt(startingJ);
                        while(s2.charAt(startingJ) <= prev)
                        {
                            output.append(s2.charAt(startingJ));
                            prev = s2.charAt(startingJ);
                            startingJ++;
                        }
                        i = startingI;
                        j = startingJ;
                    }
                }
            }
            
            
            //We reached the end of 1 string
            //Add rest of string 1
            while(i < s1.length())
            {
                output.append(s1.charAt(i));
                i++;
            } 
            
            //Add rest of string 2
            while(j < s2.length())
            {
                output.append(s2.charAt(j));
                j++;
            }
            
            
            //Print the output
            System.out.println(output);
        }
    }
}