//Problem: https://www.hackerrank.com/challenges/bigger-is-greater
//Java 8
import java.io.*;
import java.util.*;
import java.lang.StringBuilder;

public class Solution {

    public static void main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution. */
        Scanner input = new Scanner(System.in);
        int T = input.nextInt();
        input.nextLine();
        
        for(int i = 0; i < T; i++)
        {	
            String word = input.nextLine();
            if(word.length()==1) {System.out.println("no answer");continue;}
            
            
            int maxLexoC1 = 0; //The max lexocographical according to condition 1
            int maxLexoC2 = 0; //The max lexocographical according to condition 2
            
            
            
            //Find the largest index char that is weakly increasing such as g in hefg 
            for(int j = 1; j < word.length(); j++)
            {
                boolean condition1 = word.charAt(j) > word.charAt(j-1);
                    
                if(condition1)
                {
                    maxLexoC1 = (j > maxLexoC1) ? j : maxLexoC1;
                }
            }
            
            //if our only increasing is at point 0 then we are in the last permuation of our string
            if(maxLexoC1==0) {System.out.println("no answer");continue;}
            
            //maxLexoC2
            //Determine the right most char greater than the pivot in index and in lexo
            for(int j = maxLexoC1; j < word.length(); j++)
            {
                boolean condition2 = word.charAt(j) > word.charAt(maxLexoC1-1);
                    
                if(condition2)
                {
                    maxLexoC2 = j;
                }
            }
            
            StringBuilder wordSB = new StringBuilder(word);
            
            //Swap the pivot with maxLexoC2
            char tmp = wordSB.charAt(maxLexoC1-1);
            wordSB.setCharAt(maxLexoC1-1, wordSB.charAt(maxLexoC2));
            wordSB.setCharAt(maxLexoC2, tmp);
                        
            
            //Reverse starting at the element to the right of the pivot
            int left = maxLexoC1;
            int right = wordSB.length()-1;
            while(left < right)
            {
                //swap left with right
                tmp = wordSB.charAt(left);
                wordSB.setCharAt(left, wordSB.charAt(right));
                wordSB.setCharAt(right, tmp);
                left++;
                right--;
            }
            
            
            System.out.println(wordSB);
        }
    }
}