//Problem: https://www.hackerrank.com/challenges/the-time-in-words
//Java 8
import java.io.*;
import java.util.*;

public class Solution {

    public static void main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution. */
        Scanner input = new Scanner(System.in);
        int H = input.nextInt();
        int M = input.nextInt();
        
        HashMap<Integer, String> words = new HashMap<>();
        ///////////////////////////////////////////////////////
        words.put(1,"one");words.put(2,"two");
        words.put(3,"three");words.put(4,"four");
        words.put(5,"five");words.put(6,"six");
        words.put(7,"seven");words.put(8,"eight");
        words.put(9,"nine");words.put(10,"ten");
        words.put(11,"eleven");words.put(12,"twelve");
        
        words.put(13,"thirteen");
        words.put(14,"fourteen");
        words.put(15,"fifteen");
        words.put(16,"sixteen");
        words.put(17,"seventeen");
        words.put(18,"eighteen");
        words.put(19,"nineteen");
        
        ///////////////////////////////////////////////////////
        
        if (M == 0){System.out.print(words.get(H)+" o' clock");System.exit(0);}
        
        if(M < 30)
        {
            if(M > 1)
            {
                if(M > 20)
                {System.out.print("twenty "+words.get(M-20)+" minutes past "+words.get(H));}
                else if(M == 15)
                {System.out.print("quarter past "+words.get(H));}
                else
                {System.out.print(words.get(M)+" minutes past "+words.get(H));}
            }
            else
            {System.out.print(words.get(M)+" minute past "+words.get((H+1)%12));}
        }
        else if(M > 30)
        {
            if(M==45)
            {System.out.print("quarter to "+words.get((H+1)%12));}
            else if(60-M > 20)
            {System.out.print("twenty "+words.get(60-M-20)+" minutes to "+words.get((H+1)%12));}
            else if(60-M < 20){System.out.print(words.get(60-M)+" minutes to "+words.get((H+1)%12));}
            else{System.out.println("twenty minutes to "+words.get((H+1)%12));}
        }
        else
        {System.out.print("half past "+words.get(H));}
        
    }
}