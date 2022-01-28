//Problem: https://www.hackerrank.com/challenges/beautiful-triplets
//Java 8
import java.io.*;
import java.util.*;

public class Solution {

    public static void main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution. */
        Scanner input = new Scanner(System.in);
        int n = input.nextInt();
        int d = input.nextInt();
        List<Integer> arr = new ArrayList<>();  // to add all Array Elements as It will be used Later
        Set<Integer>  values = new HashSet<>();
        
        int beautifulTriplets = 0;
        
        
        //Build a set
        for(int i = 0; i < n; i++)
        {
            int x = input.nextInt();
            arr.add(x);
            if(!values.contains(x))
            {
                values.add(x);
            }
        }
        
        
        //Check if set has a value, value+d, and value + 2d
        for(Integer digit : arr)  // use " arr " in place of " values " as if the input Value have any Repetition it need to be Counted.
        {
            if(values.contains(digit+d) && values.contains(digit+(2*d)))
            {
                beautifulTriplets++;
            }
        }
        
        System.out.println(beautifulTriplets);
    }
}
