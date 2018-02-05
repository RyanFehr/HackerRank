/*
         Problem: https://www.hackerrank.com/challenges/qheap1/problem
         C# Language Version: 6.0
         .Net Framework Version: 4.7
         Tool Version : Visual Studio Community 2017
         Thoughts : It is a custom heap implementation. It doesn't follow standard binary heap tree ADT.

         For inserting a new node into the binary heap tree:

             1. Add the new element n to the end of the array.
             2. If size of the array is 1 after insertion then go to step 5 else go to step 3.
             3. We have to reheapify our binary heap tree by percolating up the newly added element. Let the 
                index of the newly added element in the array is i.
             4. Start a loop and continue untill value of i > 0
                4.1 Let the value of parent node located at position (i - 1) / 2 be p.
                4.2 If n > p then break the loop and go to step 5.
                4.3 If n < p then swap the positions of node n with its parent node p in the array.
                4.4 Set the value of i with new index position of n in the array.
                4.5 Keep repeating steps from 4.1 through 4.4 unless condition for breaking the loop isn't met.
             5. The binary tree is now a binary heap tree. No more heapification is required.

         Time Complexity:  O(log(n)) //in worst case due to heapification the newly added node will have to traverse
                                    //through all the levels present in the heap tree to reach to root node. Height of a
                                    //binary heap tree is log n hence the complexity.
         Space Complexity: O(1) //number of dynamically allocated variables remain constant for any input.
             
         For deleting a new node into the binary heap tree: Please note here that this deletion isn't in accordance with
         standard binary heap tree ADT. In standard binary heap tree ADT we always have to delete the root  node but here
         any node can be deleted randomly.

             1. Let the value of the node to be deleted is n.
             2. Iterate from starting of the array to find n in the array. Let the array index where n was found be i.
             3. If i is last element of array then remove the last element of the array and jump to step xxxx.
             4. If i is not the last element of the array then replace the element at position i with last element of the array. 
             5. Remove the last element of the array.
             6. Let the element now present at index i is n.
             7. If i is 0 OR value of parent node at index (i-1)/2 is less than n then we need to percolate down the node at at index i. Keep repeating this
                percolation down process for the node untill the tree is fully heapified.
             8. If value of parent node at index (i-1)/2 is greater than n then we need to percolate up the node at at index i.Keep repeating this
                percolation up process for the node untill the tree is fully heapified.
             9. The binary tree is now a binary heap tree. No more heapification is required.

         Time Complexity:  O(n)      //In worst case we might have to traverse the entire array to find the index of the element to be deleted which is of order O(n).
                                    //And then in worst case the heapification process might require O(log n) time to traverse through all levels of the tree.
                                    //so O(n) + O (log(n)) ~ O(n)
         Space Complexity: O(1) //number of dynamically allocated variables remain constant for any input.

        
         For printing:
            1. Print the root of the binary heap tree which is the element at 0th index of the underlying array.

         Time Complexity:  O(1)    //we simply have to print the element at 0th index of the underlying array.
         Space Complexity: O(1)    //There are no dynamically allocated variables for this operation.
         
        */

using System;
using System.Collections.Generic;

class Solution
{
    static void Main(String[] args)
    {
        var queryCount = int.Parse(Console.ReadLine());

        //initialize heap binary tree.
        var heapTree = new Heap();

        for (int i = 0; i < queryCount; i++)
        {
            var query = Console.ReadLine();
            var tempValues = query.Split(' ');
            var queryType = int.Parse(tempValues[0]);
            switch (queryType)
            {
                case 1:
                    //add a node into binary heap tree
                    var valToBeAdded = int.Parse(tempValues[1]);
                    heapTree.Insert(valToBeAdded);
                    break;
                case 2:
                    //delete a node from binary heap tree
                    var valToBeDeleted = int.Parse(tempValues[1]);
                    heapTree.DeleteSpecificValueFromHeap(valToBeDeleted);
                    break;
                case 3:
                    //print root node
                    Console.WriteLine(heapTree.Root);
                    break;
            }
        }
    }
}

public class Heap
{
    List<int> items;

    public int Root
    {
        get { return items[0]; }
    }

    public Heap()
    {
        items = new List<int>();
    }

    public void Insert(int item)
    {
        items.Add(item);

        if (items.Count <= 1)
            return;

        PercolateUpTheNode(items.Count - 1);
    }

    public void DeleteSpecificValueFromHeap(int val)
    {
        for (var i = 0; i < items.Count; i++)
        {
            if (items[i] == val)
            {
                if (i == items.Count - 1)
                {
                    //you are deleting the right most leaf node at the lowest level
                    //so nothing needs to be done apart from deleting the node.
                    items.RemoveAt(items.Count - 1);
                    break;
                }

                items[i] = items[items.Count - 1];
                items.RemoveAt(items.Count - 1);

                if (i == 0)
                    //it is the root node. The only option is to percolate down.
                    PercolateDownTheNode(i);
                else
                {
                    var parentNodeValue = items[(i - 1) / 2];
                    if (items[i] < parentNodeValue)
                        PercolateUpTheNode(i);
                    else
                        PercolateDownTheNode(i);
                }

                break;
            }
        }

    }

    private void PercolateDownTheNode(int i)
    {
        while (i < items.Count / 2)
        {
            //get the min child first
            int minChildIndex = 2 * i + 1;
            if (minChildIndex < items.Count - 1 && items[minChildIndex] > items[minChildIndex + 1])
            {
                minChildIndex++;
            }

            if (items[i] <= items[minChildIndex])
                return;//I'm smaller than the minimum of my children

            //swap
            int temp = items[i];
            items[i] = items[minChildIndex];
            items[minChildIndex] = temp;

            i = minChildIndex;
        }
    }

    private void PercolateUpTheNode(int i)
    {
        while (i > 0)
        {
            var parentNodeValue = items[(i - 1) / 2];
            var newNodeValue = items[i];

            if (newNodeValue < parentNodeValue)
            {
                //we need to percolate up this node. so swap it with parent.
                items[(i - 1) / 2] = newNodeValue;
                items[i] = parentNodeValue;
                //update the position of newly inserted node after swapping
                i = (i - 1) / 2;
            }
            else
                break;
        }
    }

}