//Problem: https://www.hackerrank.com/challenges/journey-to-the-moon
//Java 8
import java.io.*;
import java.util.*;

public class Solution {

    public static void main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution. */
        Scanner input = new Scanner(System.in);
        int N = input.nextInt();
        int I = input.nextInt(); 
        
        int[] astronauts = new int[N];                       //directed graph
        HashMap<Integer,Integer> countries = new HashMap<>();//Will be used as a bag
        
        

        //We will use q and qq for our loop variables because I has already been used
        
        //We intialize our array with each node as it's own representative
        Arrays.fill(astronauts, -1);
        
        //Converts our array into a directed graph that points from one astronaut to another in the same country until
        //you reach the last astronaut with a pointer to itself
        for(int q = 0; q < I; q++)
        {
            int parent = input.nextInt();
            int child = input.nextInt();
            
            
            astronauts[parent] = (astronauts[parent] == -1) ? parent : astronauts[parent];
            astronauts[child] = (astronauts[child] == -1) ? child : astronauts[child];
             
            //Joining two graphs
            int oldRep = astronauts[child];
            astronauts[child] = astronauts[parent];

            //Updates pointers when combining two graphs with different representatives
            for(int qq = 0; qq < N; qq++)
            {
                if(astronauts[qq] == oldRep)
                {
                    astronauts[qq] = astronauts[parent];
                }
            }
        }//for
        
        /*  This builds a Hashmap of our astronauts based on country using our directed graph.
        
        Using a hasmap here instead of going straight to an array is a design decision based on the assumption that
        the majority of cases will have multiple items in a set, so we reduce our space to 2*(number of countries) compared to 
        N size array which will only be smaller in the case where more than half of the astronauts are the only astronaut within 
        their country*/
        
        for(int person : astronauts)
        {
            if(countries.get(person) == null)
            {
                countries.put(person, 1);
            }
            else
            {
                countries.put(person, countries.get(person) + 1);
            }
        }
        
        
        //Move our values into an array where we can access them easier
        int[] tmp = new int[countries.size()];
        
        long lonelyAstronauts = 0; //Astronauts who are the only one in their country
                                  //If we do have lonely astronauts then the last index will be 0
                                  //#We store this as long because we will use it in a long calc later
        int j = 0;
        for(Map.Entry<Integer,Integer> country : countries.entrySet())
        {            
            if(country.getKey() == -1)
            {
                lonelyAstronauts = (long) country.getValue();
                continue;
            }
            
            tmp[j] = country.getValue();
            j++;
        }
        
        
        
        
        //Calculate possible combinations based on our sets //Stored as long because combinations of 10^5 can get large
        long combinations = 0;
        
        for(int q = 0; q < tmp.length; q++)
        {
            for(int qq = q+1; qq < tmp.length; qq++)
            {
                combinations += tmp[q] * tmp[qq];
            }
        }
        
        //Added the increased combinations as a result of our single astronaut countries
        if(lonelyAstronauts != 0)
        {
            combinations += (lonelyAstronauts * (N-lonelyAstronauts)) + (((lonelyAstronauts-1)*lonelyAstronauts)/2);
        }
        
        System.out.println(combinations);
    }
}