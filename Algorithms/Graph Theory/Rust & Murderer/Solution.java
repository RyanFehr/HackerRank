//Problem: https://www.hackerrank.com/challenges/rust-murderer
//Java 8
/*
Initial Thoughts: Since we know the graph of main roads, but need
                  to travel only on side roads, we will need to 
                  get the inverse of the main road graph. Then we
                  can just run a bfs shortest path on the new graph
                  
Optimization: Instead of inversing the graph, we can just run BFS on
              all non-neighbors thus removing the inverse graph step

Per test case
Time Complexity: O(N + M) //We must visit every node once and we do so my way of the main roads
Space Complexity: O(N)

*/
import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        int T = input.nextInt();
        for(int t = 0; t < T; t++)
        {
            int N = input.nextInt();//Cities(nodes)
            int M = input.nextInt();//Main roads(edges)
            HashMap<Integer,HashSet<Integer>> cityMap = new HashMap<>();

            //Build city map of main roads
            for(int i = 0; i < M; i++)
            {
                int source = input.nextInt();
                int target = input.nextInt();
                if(cityMap.containsKey(source)) cityMap.get(source).add(target);
                else 
                {
                    HashSet<Integer> roads = new HashSet<>(); roads.add(target);
                    cityMap.put(source, roads);
                }
                if(cityMap.containsKey(target)) cityMap.get(target).add(source);
                else 
                {
                    HashSet<Integer> roads = new HashSet<>(); roads.add(source);
                    cityMap.put(target, roads);
                }
            }
            
            //Starting point of search
            int startingPoint = input.nextInt();
            
            //Perform a BFS by traversing non-edges
            int[] distances = BFS_Distance(startingPoint, cityMap, N);
            
            //Print output
            StringBuilder output = new StringBuilder("");
            for(int i = 0; i < distances.length; i++)
            {
                if(i+1 != startingPoint)
                    output.append(distances[i]+" ");
            }
            System.out.println(output);
        }
    }
    
    //Performs a BFS from starting point to all non-neighbors
    static int[] BFS_Distance(int root, HashMap<Integer,HashSet<Integer>> graph, int N)
    {
        int[] distances = new int[N];
        
        HashSet<Integer> notVisited = new HashSet<>();
        HashSet<Integer> visited = new HashSet<>();
        for(int i = 1; i <= N; i++) notVisited.add(i);
        
        Queue<Integer> queue = new LinkedList<>();
        
        queue.offer(root);
        notVisited.remove(root);
        distances[0] = 0;
        
        while(!queue.isEmpty())
        {
            int curr = queue.poll();
            HashSet<Integer> neighbors = graph.get(curr);
                
            for(int nv : notVisited)
            {
                if(neighbors == null || !neighbors.contains(nv))
                {
                    queue.offer(nv);
                    distances[nv-1] = distances[curr-1]+1;
                    visited.add(nv);
                } 
            }
            notVisited.removeAll(visited);
            visited = new HashSet<>();
        }
        return distances;
    }
}