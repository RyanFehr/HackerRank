//Problem: https://www.hackerrank.com/challenges/queens-attack-2
//Java 8
/*
Initial Thoughts:
We can keep a running closest obstacle
for each direction with relation to
our queen as we read in all the obstacles
then we can just calculate the squares covered
using the distance between two points for each
of the closest obstacles

Time Complexity: O(k) //We need to check every obstacle
Space Complexity: O(1) //We only store the closest of the 8 directions
*/
import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int n = in.nextInt();
        int k = in.nextInt();
        int rQueen = in.nextInt();
        int cQueen = in.nextInt();
        
        //Row Column coordinates of the closes object in each direction
        int rRObstacle = -1;
        int cRObstacle = -1;
        int rBRObstacle = -1;
        int cBRObstacle = -1;
        int rBObstacle = -1;
        int cBObstacle = -1;
        int rBLObstacle = -1;
        int cBLObstacle = -1;
        int rLObstacle = -1;
        int cLObstacle = -1;
        int rTLObstacle = -1;
        int cTLObstacle = -1;
        int rTObstacle = -1;
        int cTObstacle = -1;
        int rTRObstacle = -1;
        int cTRObstacle = -1;
        
        //Total squares attacked by the queen
        int reachableSquares = 0;
        
        //Finds the closest object in each direction
        for(int a0 = 0; a0 < k; a0++){
            int rObstacle = in.nextInt();
            int cObstacle = in.nextInt();
            
            //Right
            if((cObstacle < cRObstacle || rRObstacle == -1) && cObstacle > cQueen && rObstacle == rQueen)
            {
                rRObstacle = rObstacle;
                cRObstacle = cObstacle;
            }
            
            //Bottom Right
            if(rQueen - rObstacle == cObstacle - cQueen && cObstacle > cQueen && rObstacle < rQueen 
               && ((rObstacle > rBRObstacle && cObstacle < cBRObstacle) || rBRObstacle == -1))
            {
                rBRObstacle = rObstacle;
                cBRObstacle = cObstacle;
            }
            
            //Bottom    
            if((rObstacle > rBObstacle || rBObstacle == -1) && rObstacle < rQueen && cObstacle == cQueen)
            {
                rBObstacle = rObstacle;
                cBObstacle = cObstacle;
            }
            
            //Bottom Left
            if(rQueen - rObstacle == cQueen - cObstacle && cObstacle < cQueen && rObstacle < rQueen 
               && ((rObstacle > rBLObstacle && cObstacle > cBLObstacle) || rBLObstacle == -1))
            {
                rBLObstacle = rObstacle;
                cBLObstacle = cObstacle;
            }
            
            //Left
            if((cObstacle > cLObstacle || rLObstacle == -1) && cObstacle < cQueen && rObstacle == rQueen)
            {
                rLObstacle = rObstacle;
                cLObstacle = cObstacle;
            }
            
            //Top Left
            if(cQueen - cObstacle == rObstacle - rQueen && cObstacle < cQueen && rObstacle > rQueen 
               && ((rObstacle < rTLObstacle && cObstacle > cTLObstacle) || rTLObstacle == -1))
            {
                rTLObstacle = rObstacle;
                cTLObstacle = cObstacle;
            }
            
            //Top
            if((rObstacle < rTObstacle || rTObstacle == -1) && rObstacle > rQueen && cObstacle == cQueen)
            {
                rTObstacle = rObstacle;
                cTObstacle = cObstacle;
            }
            
            //Top Right
            if(rObstacle - rQueen == cObstacle - cQueen && cObstacle > cQueen 
               && rObstacle > rQueen && ((rObstacle < rTRObstacle && cObstacle < cTRObstacle) || rTRObstacle == -1))
            {
                rTRObstacle = rObstacle;
                cTRObstacle = cObstacle;
            }
                           
        }
        
        //Calculates the distance to the closest obstacle in each direction and adds it to reachableSquares
        //R B L T
        reachableSquares += (cRObstacle != -1) ? (cRObstacle - cQueen -1) : n - cQueen;     
        reachableSquares += (rBObstacle != -1) ? (rQueen - rBObstacle - 1) : rQueen - 1;   
        reachableSquares += (cLObstacle != -1) ? (cQueen - cLObstacle -1) : cQueen - 1;  
        reachableSquares += (rTObstacle != -1) ? (rTObstacle - rQueen - 1) : n - rQueen;

        //BR BL TL TR
        reachableSquares += (cBRObstacle != -1) ? (cBRObstacle - cQueen -1) : Math.min(n - cQueen, rQueen - 1); 
        reachableSquares += (rBLObstacle != -1) ? (cQueen - cBLObstacle - 1) : Math.min(cQueen - 1, rQueen - 1); 
        reachableSquares += (cTLObstacle != -1) ? (cQueen - cTLObstacle -1) : Math.min(cQueen - 1, n - rQueen);  
        reachableSquares += (rTRObstacle != -1) ? (cTRObstacle - cQueen - 1) : Math.min(n - cQueen, n - rQueen); 
        System.out.println(reachableSquares);
    }
}
