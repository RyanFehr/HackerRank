//Problem: https://www.hackerrank.com/challenges/chocolate-feast
//Java 8

/*
We have n dollars
Chocolate cost c dollars
you can trade m wrappers for 1 chocolate

Example
m = 2
n = 4
c = 1


Buy 4 chocolates
trade 4 wrappers for 2 chocolates
trade 2 wrappers for 1 chocolate

Ate 7 chocolates 

Chocolates ate = 0

chocolatesValue = money / cost per chocolate

ate += CV

while(chocolate value > 0)
chocolatesValue = chocolatesValue / wrapperExchangeRate + modulus
are += CV

can we determine based on initial wrappers how many possibly candies can
be gotten taking into account future exchanges?

10 wrappers and 2 ER

10 5 3 2 0

3

10 4 2

11 5 3 0

So far I don't see a way so lets code a implementation and see what we can learn

runtime O(n/2) O(n)
*/


import java.io.*;
import java.util.*;

public class Solution {

    public static void main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution. */
        Scanner input = new Scanner(System.in);
        int t = input.nextInt();
        
        for(int i = 0; i < t; i++)
        {
            int n = input.nextInt();
            int c = input.nextInt();
            int m = input.nextInt();
            
            int ate = 0;
            
            int chocolates = n / c;
            
            ate += chocolates;

            while(chocolates >= m)
            {
                ate += chocolates / m;
                chocolates = (chocolates / m) + (chocolates % m);
            }
            System.out.println(ate);
        }
    }
}