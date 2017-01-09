//  Task 
//Given an integer, , perform the following conditional actions:
//
//If  is odd, print Weird
//If  is even and in the inclusive range of  to , print Not Weird
//If  is even and in the inclusive range of  to , print Weird
//If  is even and greater than , print Not Weird


//
//Input Format
//
//A single line containing a positive integer, .
//


//Output Format
//
//Print Weird if the number is weird; otherwise, print Not Weird.


//Sample Input 0
//
//3
//Sample Output 0
//
//Weird


//Sample Input 1
//
//24
//Sample Output 1
//
//Not Weird







	import java.io.*;
    import java.util.*;
    import java.text.*;
    import java.math.*;
    import java.util.regex.*;

    public class Solution {

        public static void main(String[] args) {

            Scanner sc=new Scanner(System.in);
            int n=sc.nextInt();            
            String ans="";
            if(n%2==1){ans = "Weird";}
            else if(n >= 2 && n <= 5){ans ="Not Weird";}
            else if(n >= 6 && n <= 20){ ans = "Weird";}
            else if(n>20){ans = "Not Weird";}
            
            System.out.println(ans);
            
        }
    }