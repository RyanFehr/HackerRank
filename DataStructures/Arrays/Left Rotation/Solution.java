/*
https://www.hackerrank.com/challenges/array-left-rotation/problem
Java 8

Initial thoughts
We can remove the first element, shift the rest elements left by 1 position,
then add the removed element to the end

Optimization
Modification to the array is not really necessary.
We print the array starting from the index d
If bound is hit, we use modulo operation to go back to index 0

 */

import java.io.*;
import java.util.*;

public class Solution {

    public static void main(String[] args) throws IOException {
        Scanner input = new Scanner(System.in);
        int n = input.nextInt();
        int d = input.nextInt();
        int[] a = new int[n];

        for (int i = 0; i < n; i++) {
            a[i] = input.nextInt();
        }

        // left rotation
        StringBuilder s = new StringBuilder();
        for (int i = 0; i < n; i++) {
            s.append(a[(i+d)%n]);
            s.append(" ");
        }
        System.out.println(s.toString());
    }
}
