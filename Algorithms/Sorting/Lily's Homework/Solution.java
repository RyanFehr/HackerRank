//Problem: https://www.hackerrank.com/challenges/lilys-homework
//Java 8
/*
Initial Thoughts: We can compare a sorted array to the original
                  and just keep track of the differences. As we
                  go we will need to perform the swaps, becasue we
                  are not guranteed 1 swap will fix both elements.
                  We will do this on both a ascending sort and a
                  descending sort as both meet the minimal 
                  requirement
                  
Time Complexity: O(n log(n)) //We must sort the input
Space Complexity: O(n) //We store the input in an array
*/
import java.io.*;
import java.util.*;

public class Solution {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        int n = input.nextInt();
        
        int sortedSwaps = 0;
        int[] homework = new int[n];
        Integer[] homeworkSorted = new Integer[n];
        Map<Integer,Integer> original = new HashMap<>();
        
        int sortedReverseSwaps = 0;    
        int[] homework2ndCopy = new int[n];        
        Map<Integer,Integer> original2ndCopy = new HashMap<>();
        
        //Initialize our arrays and maps
        for(int i = 0; i < n; i++)
        {
            homeworkSorted[i] = input.nextInt();
            homework[i] = homeworkSorted[i];
            homework2ndCopy[i] = homeworkSorted[i];
            original.put(homework[i],i);
            original2ndCopy.put(homework2ndCopy[i],i);
        }
            
        Arrays.sort(homeworkSorted);//Sort the input ascending
        
        for(int i = 0; i < n; i++)
        {
            if(homework[i] != homeworkSorted[i])
            {
                //swap the element from homework to the right position
                int tmp = homework[i];
                homework[i] = homework[original.get(homeworkSorted[i])];
                homework[original.get(homeworkSorted[i])] = tmp;
                //Update index after swap
                original.put(tmp,original.get(homeworkSorted[i]));
                sortedSwaps++;               
            }
        }
        
        Arrays.sort(homeworkSorted, Collections.reverseOrder());//Sort the input descending
        
        for(int i = 0; i < n; i++)
        {
            if(homework2ndCopy[i] != homeworkSorted[i])
            {
                //swap the element from homework to the right position
                int tmp = homework2ndCopy[i];
                homework2ndCopy[i] = homework2ndCopy[original.get(homeworkSorted[i])];
                homework2ndCopy[original2ndCopy.get(homeworkSorted[i])] = tmp;
                //Update index after swap
                original2ndCopy.put(tmp, original2ndCopy.get(homeworkSorted[i]));
                sortedReverseSwaps++;
            }
        }
        System.out.println(Math.min(sortedSwaps,sortedReverseSwaps));//Choose the smallest of the two possible smallest
    }
}