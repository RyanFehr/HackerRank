//Problem: https://www.hackerrank.com/challenges/lisa-workbook
//Java 8
/*
page number = 1
problem number
4  (4 - k)  = 1 3 < 4 will be on page 1  -> is 1 equivalent to 4 - 3 , - 2, -1
    loop over remainder until remainder < 0
    handle the <k problems page vs problem number
2
6
1
10


*/



import java.io.*;
import java.util.*;

public class Solution {

    public static void main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution. */
        Scanner input = new Scanner(System.in);
        int n = input.nextInt();
        int k = input.nextInt();
        int pageNumber = 1;
        int specialProblems = 0;
        
        for(int i = 0; i < n; i++)
        {
            int problems = input.nextInt(); 
            int currentProblem = 1; //Set the current problem for each chapter to 1 on start
            
            while(problems > 0) //Loop through all problems for this chapter
            {
                int pageProblems = problems;
                pageProblems -= k;
                
                if(pageProblems > 0)  //Determine if there are enough problems left for a full page
                {pageProblems = k;}
                else                  //If not just run the remaining problems
                {pageProblems += k;}
                
                //System.out.println("adding "+ pageProblems +" problems to a page");
                
                while(pageProblems > 0)    //While we still have problems to put on the current page
                {
                    //System.out.println("Problem "+currentProblem+" was put on page "+ pageNumber);
                    if(pageNumber == currentProblem)  //If the current problem we are adding to a page is the same index as the   
                    {                                 //page increment specialProblems
                        specialProblems++;
                    }
                    currentProblem++; 
                    pageProblems--;
                }
                
                problems -= k; //Remove the problems we have added to the page
                pageNumber++; //Move to next page
            }
        }
        System.out.println(specialProblems);
        
    }
}