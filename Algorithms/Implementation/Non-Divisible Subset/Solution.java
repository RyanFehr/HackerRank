//Problem: https://www.hackerrank.com/challenges/non-divisible-subset
//Java 8
import java.io.*;
import java.util.*;
import java.lang.Math;

public class Solution {

    public static void main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution. */
        //Example:
        //4 3
        //1 7 2 4
        //                  0 1 2
        //modulusBuckets:  |0|3|1|
        //largest of the possible bucket combinations is 3
        //
        //19 13
        // 1 2 3 4 5 6 7 20 23 24 26 35 46 79 45 36 25 14 13
        //
        //                  0  1  2  3  4  5  6  7  8  9  10 11 12
        //modulusBuckets:  |2 |3 |1 |1 |1 |1 |2 |3 |0 |1 |2 |1 |1 |
        
        
        
        Scanner input = new Scanner(System.in);
        int N = input.nextInt();
        int K = input.nextInt();
        
        int nonDivisibleSubsetCardinality = 0;
        
        int[] modulusBuckets = new int[K];
        
        //Place the values in buckets based on mod K
        for(int i = 0; i < N; i++)
        {
            int bucket = input.nextInt() % K;
            modulusBuckets[bucket] += 1;
        }
        
        //Adds 1 if there is only 1 element in the 0 bucket or the k/2 bucket because these are edge cases
        nonDivisibleSubsetCardinality += (modulusBuckets[0] >= 1) ? 1 : 0;
        nonDivisibleSubsetCardinality += (K%2 == 0 && modulusBuckets[K/2] >= 1) ? 1 : 0;
        
        //Determine the max buckets we can use
        int maxBuckets = 0;
        if(K%2 == 0)
        {
            maxBuckets = (K/2)-1;
        }
        else
        {
            maxBuckets = K/2;
        }
        
        //Picks the biggest bucket of each pair for each even sum group
        for(int i = 1; i <= maxBuckets; i++)
        {
            nonDivisibleSubsetCardinality += Math.max(modulusBuckets[i], modulusBuckets[K-i]);
        }
        
        System.out.println(nonDivisibleSubsetCardinality);
    }
}