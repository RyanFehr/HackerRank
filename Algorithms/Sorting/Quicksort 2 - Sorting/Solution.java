//Problem: 
//Java 8
/*
Initial Thoughts:
This is a basic Quicksort, with a lot of extra space used so
that you can meet the ridiculous requirements of printing
the array in a specific order. I want to say thanks to
Ankur Sharma for helping me deal with the annoying 
restrictions of this problem.

Time Complexity: O(n^2)
Space Complexity: O(n)
*/
import java.util.*;

public class Solution {

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int n = in.nextInt();
        int[] ar = new int[n];
        for(int i=0;i<n;i++)
        {
           ar[i]=in.nextInt(); 
        }
        quickSort(ar, 0, ar.length-1);
    }

    static void quickSort(int array[], int beg, int end)
    {
        if(beg >= end)
            return;

        int wall = partition (array,beg,end);

        quickSort(array,beg,wall-1);
        quickSort(array,wall+1,end);

        printArray(array,beg, end);
    }
    
    static int partition(int array[], int beg, int end)
    {
        int pivot = array[beg];
        List<Integer> left = new ArrayList<>();
        List<Integer> right = new ArrayList<>();

        for(int i = beg+1 ; i <= end; i++)
        {
               if(array[i] > pivot)
                   right.add(array[i]);
               else
                   left.add(array[i]);
        }
        copy(left,array,beg);
        int wall = left.size()+beg;
        array[wall] = pivot;
        copy(right,array,wall+1);

        return beg + left.size();
    }

    static void copy(List<Integer> list, int array[], int beg)
    {
        for(int num : list)
        {
           array[beg++] = num;      
        }
    }

    static void printArray(int[] ar,int beg, int end)
    { 
        for(int i = beg; i <= end;i++)
        { 
            System.out.print(ar[i]+" "); 
        } 
        System.out.println("");
    }
}