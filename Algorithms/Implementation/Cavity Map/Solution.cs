/*
         Problem: https://www.hackerrank.com/challenges/cavity-map/problem
         C# Language Version: 7.0
         .Net Framework Version: 4.7
         Tool Version : Visual Studio Community 2017
         Key notes:
         - Basic idea is that we've to check all the positions which are not at boundary.
           a b c d
           e f g h
           i j k l
           m n o p
           So we've to check f,g,j,k positions only.
         - For any position being checked just compare it depth with all its adjacent positions sharing an edge
            and replace it with 'X' if it is deepest in its neighborhood.

         Time Complexity:  O(n^2) //there is a nested loops where we've to iterate entire array except the ones on the boundary.
         Space Complexity: O(n^2) //we've to save n lines of input as a square matrix map for managing depths.
                
        */

using System;

class Solution
{
    static string[] CavityMap(string[] grid)
    {
        for (var row = 1; row < grid.Length - 1; row++)
        {
            for (var column = 1; column < grid.Length - 1; column++)
            {
                if (grid[row][column] > grid[row - 1][column]
                    && grid[row][column] > grid[row + 1][column]
                    && grid[row][column] > grid[row][column - 1]
                    && grid[row][column] > grid[row][column + 1])
                {
                    var removeCavity = grid[row].Remove(column, 1).Insert(column, "X");

                    grid[row] = removeCavity;
                }
            }
        }
        return grid;
    }

    static void Main(String[] args)
    {
        var n = int.Parse(Console.ReadLine());
        //grid has n rows.
        var grid = new string[n];
        for (var grid_i = 0; grid_i < n; grid_i++)
            grid[grid_i] = Console.ReadLine();
        var result = CavityMap(grid);
        Console.WriteLine(string.Join("\n", result));


    }
}
