//Problem: https://leetcode.com/problems/next-permutation/?tab=Description
//Java 8
/*
Examples:
135 -> 153 -> 315 -> 351 -> 513 -> 531 ----> 135

135
153
351
513
531
-->
135



Algorithm:
1. Find the longest decreasing sequence at the end
2. Set the pivot element as the element before your sequence
3. Swap your pivot with the right most element greater than the pivot
4. Reverse your new subsequence

Edge Cases:
Number has 1 digit
    Do nothing
    
Number is already the last perumation
    Reverse the number


Test cases:
0125330
315
127568534

*/


public class Solution {
    public void nextPermutation(int[] nums) {
        
        
        if(nums.length == 1) return;
        
        //Find the longest decreasing subsequence from end
        int suffixStart = nums.length - 1;
        while (suffixStart > 0 && nums[suffixStart - 1] >= nums[suffixStart])
            suffixStart--;
        
        
        //Set the pivot element as the element to the left of the start of the sequence
        int pivot = suffixStart - 1;
        
        //This is already the last perumtation, so we reverse it to start at the beginning
        if(pivot == -1)
        {
            for(int i = 0; i < nums.length/2; i++)
            {
                int tmp = nums[nums.length - 1 - i];
                nums[nums.length -1 - i] = nums[i];
                nums[i] = tmp;
            }
            return;
        }
        
        //Swap the pivot with the right most element greater than the pivot
        
        //Find it
        int rightMost = nums.length-1;
	    while(nums[rightMost] <= nums[pivot])
		    rightMost--;
        
        //Swap it
        int tmp = nums[rightMost];
        nums[rightMost] = nums[pivot];
        nums[pivot] = tmp;
        
        //Reverse the new subsequence that now contains the pivot and you are done
        int j = 1;
        while(suffixStart < nums.length-j)
        {
            tmp = nums[nums.length - j];
            nums[nums.length - j] = nums[suffixStart];
            nums[suffixStart] = tmp;
            j++;
            suffixStart++;
        }
    }
}