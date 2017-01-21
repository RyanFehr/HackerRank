//Problem: https://www.hackerrank.com/challenges/chief-hopper
//Java 8
import java.io.*;
import java.util.*;
import java.lang.Math;

public class Solution {

    public static void main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution. */
        Scanner input = new Scanner(System.in);
        int N = input.nextInt();
        int[] buildings = new int[N];
        int minEnergy = 0;
        
        //Builds an array of the input
        for(int i = 0; i < N; i++)
        {
            buildings[i] = input.nextInt();
        }
        
        //Goes through the input in reverse calculating the min energy required based on ending with 0 energy
        for(int i = buildings.length-1; i >= 0; i--)
        {
            int buildingHeight = buildings[i];
            
            if(buildingHeight > minEnergy)
            {
                minEnergy += (int) Math.ceil((buildingHeight - minEnergy) / 2.0);
            }
            else if(buildingHeight < minEnergy) 
            {
                minEnergy = (int) Math.ceil((buildingHeight + minEnergy) / 2.0);
            }
            
            //Nothing occurs in the == case so we simply don't check for it
        }
        
        System.out.println(minEnergy);
    }
}