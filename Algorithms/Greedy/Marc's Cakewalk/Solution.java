//Problem: https://www.hackerrank.com/challenges/marcs-cakewalk
//Java 8
/*
Initial Thoughts:
Since our calorie range is only 1000 which
is relatively small, we can do a counting sort
in linear time and beat out a n log n sorting
algo like qsort, also since our 2^j is always
increasing, we can just track it as we go and
not do pow(2,j) every time


Time Complexity: O(n + k) //We have to see every cupcake's calories
Space Complexity: O(k) //We allocate an array of size k which is max calories
*/
import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int n = in.nextInt();
        int[] calories = new int[1000];//999 index is calorie 1 and 0 index is calorie 1000
        int maxCalories = 0;
        
        //Sort the calories from largest to smallest
        for(int i=0; i < n; i++){
            calories[calories.length - in.nextInt()]++;
        }
        long miles = 0;
        long pow = 1;
        for(int i = 0; i < calories.length; i++)
        {
            for(int j = 0; j < calories[i]; j++)
            {
                miles += (calories.length - i) * pow;
                pow *= 2;
            }
        }
        
        System.out.println(miles);
    }
}
