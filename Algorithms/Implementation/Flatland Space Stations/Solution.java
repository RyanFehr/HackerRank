//Problem: https://www.hackerrank.com/challenges/flatland-space-stations
//Java 8
/*
5 2
0 4

[1 0 0 0 1]
update indices with space stations

leftNearest 
rightNearest
maxDistance 

move through the array keeping track of left and
right distance at each point
while updating our max

I expect this to take O(n)


*/


import java.io.*;
import java.util.*;

public class Solution {

    public static void main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution. */
        Scanner input = new Scanner(System.in);
        int n = input.nextInt(); //Number of cities
        int m = input.nextInt(); //Number of spacestations
        int[] map = new int[n];  //Map of all the cities
        int[] distanceMap = new int[n]; //Map containing distances to the nearest spacestation
        
        int leftNearest = n+1; //The spacestation nearest to a city from the left side
        int rightNearest = -1; //The spacestation nearest to a city from the right side
        int maxDistance  = 0;  //The max distance you have to travel from any city to a spacestation
        
        //Mark cities who have a spacestation
        for(int i = 0; i < m; i++)
        {
            int spacestation = input.nextInt();
            map[spacestation] = 1;
            
            rightNearest = (spacestation > rightNearest) ? spacestation : rightNearest;
            leftNearest = (spacestation < leftNearest) ? spacestation : leftNearest;
        }
        
        //Scan left right calculating value based on left nearest
        for(int i = 0; i < n; i++)
        {
            if(map[i] == 1)//If there is a spacestation in a given city then distance is 0 and it is the new leftNearest
            {
                distanceMap[i] = 0;
                leftNearest = i;
            }
            else
            {
                if(i > leftNearest)
                {
                    //Update the min distance from the leftNearest on the distance map
                    distanceMap[i] = i - leftNearest;
                }
                else //Occurs when there is not leftNearest spaceStation yet
                {
                    distanceMap[i] = n+1;
                }
            }
        }
        
        //Scan right left calculating value base on right nearest
        for(int i = n-1; i>= 0; i--)
        {
            if(map[i] == 1)
            {
                rightNearest = i;
            }
            else
            {
                if(rightNearest > i)
                {
                    //Update the min distance for each point on the distance map
                    distanceMap[i] = (distanceMap[i] > rightNearest - i) ? rightNearest - i : distanceMap[i];
                }
            }
            
            //Keep track of the maxDistance
            maxDistance = (distanceMap[i] > maxDistance) ? distanceMap[i] : maxDistance;
        }

        System.out.println(maxDistance);
        
    }
}