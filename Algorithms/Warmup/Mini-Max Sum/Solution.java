//Problem: https://www.hackerrank.com/challenges/mini-max-sum
//Java 8
import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {

    static void miniMaxSum(int[] arr) {
        long[] a = new long[5];
        
        //Creating an array with the sum off each 4 elements of arr[]
        for(int i = 0; i < arr.length; i++){
            for(int j = 0; j < arr.length; j++){
                if(j != i){
                    a[i] += arr[j];
                }
            }
        }
        
        //Then find the max value of a[];
        long max = 0;
        for(int i = 0; i < arr.length; i++){
            if(max < a[i]){
                max = a[i];
            }
        }
        
        //Then find the min value of a[];
        long min = max;
        for(int i = 0; i < arr.length; i++){
            if(min > a[i]){
                min = a[i];
            }
        }
        
        //This is just a stupid way to it :)
        System.out.println(min+" "+max);
    }

    private static final Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) {
        int[] arr = new int[5];

        String[] arrItems = scanner.nextLine().split(" ");
        scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");

        for (int i = 0; i < 5; i++) {
            int arrItem = Integer.parseInt(arrItems[i]);
            arr[i] = arrItem;
        }

        miniMaxSum(arr);

        scanner.close();
    }
}

