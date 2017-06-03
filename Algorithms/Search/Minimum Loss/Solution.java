//Problem: https://www.hackerrank.com/challenges/minimum-loss
//Java 8
/*

Initial Thoughts: We can sort the array to reduce the number of comparisons since
                  we know that the absolute difference is always smallest between
                  adjacent elements in a sorted array. Then because we have the 
                  stipulation that we must buy the house before we can sell it
                  we should verify that the buy price we are using is a price
                  that occurred in a year prior to the sell price year. We can
                  accomplish this by using a map that will be at most size n and
                  will store distinct key,value pairs where the key is the price
                  and the value is the year.
                  
Time Complexity: O(n log(n)) //We must sort the input array
Space Complexity: O(n) //We use a map to store the price,year pairs
*/
import java.io.*;
import java.util.*;

public class Solution {

    public static void main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution. */
        Scanner input = new Scanner(System.in);
        int n = input.nextInt();
        long[] prices = new long[n];
        HashMap<Long,Integer> indices = new HashMap<>();

        //Populate prices array with the input
        for(int i = 0; i < n; i++){
            prices[i] = input.nextLong();
            indices.put(prices[i],i);
        }

        Arrays.sort(prices);//Performs a double pivot quicksort and sorts ascending

        Long minimumLoss = Long.MAX_VALUE;

        //Iterate from end to start
        for(int i = n-1; i >0; i--){
            //Make sure it is a smaller loss
            if(prices[i]-prices[i-1] < minimumLoss){
                //Verify if the pair is a valid transaction
                if(indices.get(prices[i]) < indices.get(prices[i-1]))
                    minimumLoss = prices[i]-prices[i-1];
            }
        }

        System.out.println(minimumLoss);

    }
}