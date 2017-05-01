//Problem: https://www.hackerrank.com/challenges/fraudulent-activity-notifications
//Java 8
/*
Initial Thoughts: We can use an array to sort our transactions
                  using counting sort, since there is a small
                  range of different transactions ranging from
                  0->200. Then to get our median we can iterate
                  over our sorted array decrementing a counter
                  variable set to the d and when it hits 0, we
                  know we have found our median. In the case of
                  an even element median, we just need to keep
                  track of the current element and the prev 
                  element and then we can average them to get 
                  our median
                  
Time Complexity: O(n^2) //For each transaction we calculate median, and in worse case median takes n time
Space Complexity: O(n) //Our queue is at most d which is bounded by n
*/
import java.io.*;
import java.util.*;

public class Solution {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        int n = input.nextInt();
        int d = input.nextInt();
        int notifications = 0;
        Queue<Integer> queue = new LinkedList<>();
        int[] pastActivity = new int[201];
        
        //Wait for d transactions before any notifications
        for(int i = 0; i < d; i++)
        {
            int transaction = input.nextInt();
            queue.offer(transaction);
            pastActivity[transaction] = pastActivity[transaction]+1;
        }
            
        for(int i = 0; i < n-d; i++)
        {
            int newTransaction = input.nextInt();
            
            //Check if fraudulent activity may have occurred
            if(newTransaction >= (2* median(pastActivity, d)))
                notifications++;
                
            //Remove the oldest transaction
            int oldestTransaction = queue.poll();
            pastActivity[oldestTransaction] = pastActivity[oldestTransaction]-1;
            
            //Add the new transaction
            queue.offer(newTransaction);
            pastActivity[newTransaction] = pastActivity[newTransaction]+1;
        }
        
        System.out.println(notifications);
    }
    
    static double median(int[] array, int elements)
    {
        int index = 0;
        
        if(elements % 2 == 0)//Find median of even # of elements
        {
            int counter = (elements / 2);

            while(counter > 0)
            {                
                counter -= array[index];
                index++;
            }
            index--;//Remove extra iteration
            if(counter <= -1)//This index covers both medians
                return index;
            else//(counter == 0) We need to find the next median index 
            {
                int firstIndex = index;
                int secondIndex = index+1;
                while(array[secondIndex] == 0)//Find next non-zero transaction
                {
                    secondIndex++;
                }
                return (double) (firstIndex + secondIndex) / 2.0;//Calculate the average of middle two elements
            }
        }
        else//Find median of odd # of elements
        {
            int counter = (elements / 2);

            while(counter >= 0)
            {
                counter -= array[index]; index++;
            }
            return (double) index-1;
        }
    }
    
    
    static void printArray(int[] array)
    {
        System.out.println("Array");
        for(int i = 0; i < array.length; i++)
        {
            if(array[i] > 0)
                System.out.println(i+" : "+array[i]);
        }
    }
}