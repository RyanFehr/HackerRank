//Problem: https://www.hackerrank.com/challenges/taum-and-bday
//Java 8
import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int t = in.nextInt();
        for(int a0 = 0; a0 < t; a0++){
            long blackGifts = in.nextLong();
            long whiteGifts = in.nextLong();
            long blackPrice = in.nextLong();
            long whitePrice = in.nextLong();
            long conversionPrice = in.nextLong();
            //End of Given Code//
            
            
            //Calculate white->black and choose max between it and black
            long minBlackPrice = Math.min(blackPrice, whitePrice + conversionPrice);
            
            //Calculate black->white and choose max between it and white
            long minWhitePrice = Math.min(whitePrice, blackPrice + conversionPrice);
            
            //Multiple the price for each one by the number of gifts we need
            System.out.println((minBlackPrice * blackGifts) + (minWhitePrice * whiteGifts));
        }
    }
}
