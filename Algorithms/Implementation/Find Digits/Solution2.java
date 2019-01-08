// https://www.hackerrank.com/challenges/find-digits/problem
// Java 8

import java.io.*;
import java.util.*;

public class Solution {

    public static void main(String[] args) throws IOException {
        Scanner input = new Scanner(System.in);
        int t = input.nextInt();
        for (int i = 0; i < t; i++) {
            int num = input.nextInt();
            int oriNum = num;
            int count = 0;
            if (num == 0) {
                count += 1;
                System.out.println(count);
                return;
            }
            int pow = (int)Math.log10(num);
            int div = (int)Math.pow(10,pow);
            int digit;
            while (num > 0) {
                digit = num / div;
                int sig = digit * div;
                if (num - sig >= 0) {
                    num -= sig;
                }
                div /= 10;

                if (digit != 0 && oriNum % digit == 0) {
                    count += 1;
                }
            }
            System.out.println(count);
        }
        input.close();
    }
}

