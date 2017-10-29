//Problem: https://www.hackerrank.com/challenges/migratory-birds
//Java 8
    import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;
import java.util.stream.IntStream;


public class bird {
    static int migratoryBirds(int n, int[] ar) {
     int[] counts = new int[6];
		for (int type : ar) {
			counts[type]++;
		}

		int maxCount = IntStream.range(1, counts.length).map(i -> counts[i]).max().getAsInt();
		for (int i = 1;; i++) {
			if (counts[i] == maxCount) {
				return i;}}}

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int n = in.nextInt();
        int[] ar = new int[n];
        for(int ar_i = 0; ar_i < n; ar_i++){
            ar[ar_i] = in.nextInt();
        }
        int result = migratoryBirds(n, ar);
        System.out.println(result);
    }
}
