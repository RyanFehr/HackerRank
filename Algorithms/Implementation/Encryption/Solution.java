//Problem: https://www.hackerrank.com/challenges/encryption
//Java 8
import java.io.*;
import java.util.*;
import java.lang.Math;

public class Solution {

    public static void main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution. */
        Scanner input = new Scanner(System.in);
        
        String sentence = input.nextLine();
        
        //First we determine the rows since they are <= the columns
        int rows = (int) Math.sqrt(sentence.length());
        
        //Expand the columns if the sentence doesn't fit in a square matrix
        int columns = (sentence.length() > rows*rows) ? rows+1 : rows;
        
        //Expand the rows if the sentence still doesn't fit
        rows = (sentence.length() > rows*columns) ? rows+1 : rows;
        
        //System.out.println(rows + " x " + columns);
        
        //Move through the matrix printing the columns
        for(int i = 0; i < columns; i++)
        {
            //System.out.print(sentence.charAt(i));
            int currentIndex = i;
            for(int j = 0; j < rows; j++)
            {
                if(currentIndex <= sentence.length()-1)
                {
                    System.out.print(sentence.charAt(currentIndex));
                }
                currentIndex += columns;
            }
            if(i+1 != columns) System.out.print(" ");
        }
        
    }
}