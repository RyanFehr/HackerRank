//Problem: https://www.hackerrank.com/challenges/quicksort4
//Java 8
/*
Initial Thoughts:
We can just add a counter in our swap function of each sorting algorithm and compare them

Time Complexity: O(n^2) //We are not randomizing our pivot selection so worst case is n^2
Space Complexity: O(log n) //We recursively build log n frames on the stack
*/

import java.io.*;
import java.util.*;

public class Solution {

    static int Qswaps = 0;
    static int Iswaps = 0;
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        int n = input.nextInt();
        int ar[] = new int[n];
        for(int i = 0; i < n; i++)
        {
            ar[i] = input.nextInt();
        }
        
        //Run insertion sort on its own copy
        int[] copy = ar.clone();
        insertionSort(copy);
        
        quicksort(ar,0,ar.length-1);
        
        System.out.println(Iswaps - Qswaps);
    }
    
    static void quicksort(int[] array, int beg, int end)
    {
        if(beg >= end) return;
        
        int pivot = array[end];
        int wall = beg;
        
        //Partition with a wall
        for(int i = beg; i < end; i++)
        {
            if(array[i] < pivot)
            {
                swap(array, i, wall);
                wall++;
            }
        }
        
        //Place pivot
        swap(array, end, wall);
               
        //Sort left of partition
        quicksort(array, beg, wall-1);
        
        //Sort right of partition
        quicksort(array, wall+1, end);        
    }
    
    
    static void swap(int[] array, int index1, int index2)
    {
        int tmp = array[index1];
        array[index1] = array[index2];
        array[index2] = tmp;
        Qswaps++;
    }
    
    static void printArray(int[] array)
    {
        for(int num : array)
        {
            System.out.print(num+" ");
        }
        System.out.println("");
    }
    
    public static void insertionSort(int[] A){
        for(int i = 0; i < A.length; i++){
            int value = A[i];
            int j = i - 1;
            while(j >= 0 && A[j] > value){
                A[j + 1] = A[j];
                j = j - 1;
            }
            A[j + 1] = value;
            Iswaps += i - (j+1);
        }
    }
}