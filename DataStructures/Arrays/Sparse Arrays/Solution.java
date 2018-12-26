/*
Problem: https://www.hackerrank.com/challenges/sparse-arrays/problem
Java 8

Initial thoughts
We could loop the strings array for every element in queries array.
Time Complexity: O(n * q)  // n is the number of elements in string array, q is the number of
                              elements in queries array
Space Complexity: O(q + 1) // q is the number of results stored in the return array, 1 is a
                              variable to store the count variable

Optimization
Use HashMap to store the string frequency in strings array
Then query the HashMap for every element in queries array
Time Complexity: O(n + q)  // n is the number of elements in string array, q is the number of
                              elements in queries array
Space Complexity: O(n + q) // n is the number of entries in HashMap, q is the number of
                              results stored in the return array

 */

import java.io.*;
import java.util.*;

public class Solution {

    static int[] matchingStrings(String[] strings, String[] queries) {
        int[] re = new int[queries.length];
        Map<String, Integer> hMap = new HashMap<>();
        for (int i = 0; i < strings.length; i++) {
            Integer freq = hMap.get(strings[i]);
            hMap.put(strings[i], (freq == null) ? 1 : freq + 1);
        }
        for (int i = 0; i < queries.length; i++) {
            Integer count = hMap.get(queries[i]);
            re[i] = (count != null) ? count : 0;
        }
        return re;
    }

    public static void main(String[] args) throws IOException {
        Scanner input = new Scanner(System.in);
        int n = input.nextInt();
        String[] strs = new String[n];
        for (int i = 0; i < n; i++) {
            strs[i] = input.next();
        }
        int q = input.nextInt();
        String[] qrys = new String[q];
        for (int i = 0; i < q; i++) {
            qrys[i] = input.next();
        }

        int[] re = matchingStrings(strs, qrys);
        for (int i = 0; i < re.length; i++) {
            System.out.println(re[i]);
        }
    }
}
