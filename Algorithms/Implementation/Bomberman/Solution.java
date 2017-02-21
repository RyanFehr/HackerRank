//Problem: 
//Java 8
/*
We can simply keep three sets of bombs
1 second bombs
2 second bombs
3 second bombs


*/

import java.io.*;
import java.util.*;

public class Solution {
    
    static Map<Integer,Map<Integer,Integer>> threeSecondBombs = new HashMap<>();
    static Map<Integer,Map<Integer,Integer>> twoSecondBombs = new HashMap<>();
    static Map<Integer,Map<Integer,Integer>> oneSecondBombs = new HashMap<>();
    static Map<Integer,Map<Integer,Integer>> damagedBombs = new HashMap<>();

    public static void main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution. */
        Scanner input = new Scanner(System.in);
        int row = input.nextInt();
        int col = input.nextInt();
        int n = input.nextInt();
        input.nextLine(); 
        
        
        
        
        char[][] grid = new char[row][col];
        
        for(int i = 0; i < row; i++)
        {
            String readRow  = input.nextLine();
            for(int j = 0; j < col; j++)
            {
                if(readRow.charAt(j) == 'O')
                {
                    if(threeSecondBombs.get(i) == null)
                    {
                        Map<Integer,Integer> map = new HashMap<Integer, Integer>();
                        threeSecondBombs.put(i, map);  
                        threeSecondBombs.get(i).put(j,0);
                    }
                    else
                    {
                        threeSecondBombs.get(i).put(j,0);
                    }
                }
                    
                    
                    
                grid[i][j] = readRow.charAt(j);
            }
        }
        
        
        int cycle = 2;
        
        if(cycle <= n)//2 second cycle
        {
            //Plant all the 2 second bombs
            plantBombs(twoSecondBombs, grid);
            cycle++;
        }
        
        if(cycle <= n)//3 second cycle
        {
            detonateBombs(threeSecondBombs, grid);
            cycle++;
        }
        
        //All future cycles
        
        //These will function as switches where 0 is place and 1 is detonate
        int one = 0;
        int two = 1;
        int three = 0;
        while(cycle <= n)
        {
            if(n % 3 == 1)//One cycle
            {
                if(one == 0)
                {
                    plantBombs(oneSecondBombs, grid);
                    one = 1;
                }
                else
                {
                    detonateBombs(oneSecondBombs, grid);
                    one = 0;
                }
            }
            else if(n % 3 == 2)//Two cycle
            {
                if(two == 0)
                {
                    plantBombs(twoSecondBombs, grid);
                    two = 1;
                }
                else
                {
                    detonateBombs(twoSecondBombs, grid);
                    two = 0;
                }
            }
            else if(n % 3 == 0)//Three cycle
            {
                if(three == 0)
                {
                    plantBombs(threeSecondBombs, grid);
                    three = 1;
                }
                else
                {
                    detonateBombs(threeSecondBombs, grid);
                    three = 0;
                }
            }
            cycle++;
        }    
        
        
        //Print the output grid
        for(char[] l : grid)
        {
            for(char m : l)
            {
                System.out.print(m);
            }
            System.out.println("");
        }
        
    }
    
    static void plantBombs(Map<Integer,Map<Integer,Integer>> bombSet, char[][] grid)
    {
        bombSet = new HashMap<>();
        for(int i = 0; i < grid.length; i++)
        {
            for(int j = 0; j < grid[0].length; j++)
            {
                if(grid[i][j] == '.')
                {
                    if(bombSet.get(i) == null)
                    {
                        Map<Integer,Integer> map = new HashMap<Integer, Integer>();
                        bombSet.put(i, map);  
                        bombSet.get(i).put(j,0);
                    }
                    else
                    {
                        bombSet.get(i).put(j,0);
                    }
                    grid[i][j] = 'O';
                }
            }
        }
    }
    
    
    static void detonateBombs(Map<Integer,Map<Integer,Integer>> bombSet, char[][] grid)
    {
        for(Map.Entry<Integer, Map<Integer,Integer>> x : bombSet.entrySet())
        {
            int px = x.getKey();
            for(Map.Entry<Integer,Integer> y : x.getValue().entrySet())
            {
                removeDamage(px,y.getKey(),grid);
            }
        }
        
        for(Map.Entry<Integer, Map<Integer,Integer>> x : damagedBombs.entrySet())
        {
            int px = x.getKey();
            for(Map.Entry<Integer,Integer> y : x.getValue().entrySet())
            {
                if(threeSecondBombs.get(x) != null)
                threeSecondBombs.get(x).remove(y);

                if(twoSecondBombs.get(x) != null)
                    twoSecondBombs.get(x).remove(y);

                if(oneSecondBombs.get(x) != null)
                    oneSecondBombs.get(x).remove(y);
            }
        }
    }
    
    static void removeDamage(int x, int y, char[][] grid)
    {
        grid[x][y] = '.';
        //Left
        if(y-1 >= 0)
        {
            grid[x][y-1] = '.';
            removeBomb(x-1, y);
        }
            
        //Right
        if(y+1 < grid[0].length)
        {
            grid[x][y+1] = '.';
            removeBomb(x+1, y);
        }
        
        //Up
        if(x-1 >= 0)
        {
            grid[x-1][y] = '.';
            removeBomb(x, y-1);
        }
        
        //Down
        if(x+1 < grid.length)
        {
            grid[x+1][y] = '.';
            removeBomb(x, y+1);
        }
    }
    
    static void removeBomb(int x, int y)
    {
        /*if(threeSecondBombs.get(x) != null)
            threeSecondBombs.get(x).remove(y);*/
        Map<Integer,Integer> map = new HashMap<Integer, Integer>();
        damagedBombs.put(x, map);  
        damagedBombs.get(x).put(y,0);
        
        /*
        if(twoSecondBombs.get(x) != null)
            twoSecondBombs.get(x).remove(y);
        
        if(oneSecondBombs.get(x) != null)
            oneSecondBombs.get(x).remove(y);
            */
    }
    
    
}