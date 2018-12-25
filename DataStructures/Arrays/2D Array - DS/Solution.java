import java.io.*;
import java.util.*;

public class Solution {

    static int hourglassSum(int[][] arr) {
        int max = 0;
        for (int i = 1; i < 5; i++) {
            for (int j = 1; j < 5; j++) { // loop through the centers of hourglass
                int sum = 0;
                for (int k = j-1; k < j+2; k++) {
                    sum += arr[i-1][k];
                    sum += arr[i+1][k];
                }
                sum += arr[i][j];
                if (i == 1 && j == 1) {
                    max = sum;
                }
                if (sum > max) {
                    max = sum;
                }
            }
        }
        return max;
    }

    public static void main(String[] args) throws IOException {
        Scanner input = new Scanner(System.in);
        int[][] arr = new int[6][6];

        for (int i = 0; i < 6; i++) {
            for (int j = 0; j < 6; j++) {
                arr[i][j] = input.nextInt();
            }
        }
        int re = hourglassSum(arr);
        System.out.println(re);
    }
}
