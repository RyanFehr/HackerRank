/*
    Problem: https://www.hackerrank.com/challenges/queue-using-two-stacks/problem
    C# Language Version: 7.0
    .Net Framework Version: 4.7
    Tool Version : Visual Studio Community 2017
    Thoughts/Algorithm/pseudo code :

    1. Initialize two stacks S1 and S2.
    2. Maintain a pointer p which points to the stack whose top element represents the front of queue.
    3. Start a loop to process input queries.

   Enqueue operation (query type - 1):
   1. Let the input number be x.
   2. If both stacks are empty then push x onto s1 and set p to point to s1.
   3. If either of the stack isn't empty then push x onto s2 and set p to point to s2.

    Time Complexity:  O(1) //No loops are involved in enqueue operation involving two stacks.
    Space Complexity: O(1) //number of dynamically allocated variables remain constant for any input.


   Dequeue operation (query type - 2):
   1. If p is pointing to s1 then pop s1 once. 
   2. If the pop operation in step 1 above made s1 empty and s2 is still non empty then set p to point to s2.
   3. If p is pointing to s2 then
       - if s2 is not empty then pop all but one element from s2 and push them onto s1 as they are getting 
       popped out. Now pop the last element from s2 which effectively represents tail element of queue.

    Time Complexity:  O(n) //In worst case we end up popping an entire stack for dequeue operation.
    Space Complexity: O(1) //number of dynamically allocated variables remain constant for any input.

   Print the front of queue(query type - 3): 
   1. If p is pointing to s1 the perform peek operation on s1 and print the returned element.
   2. If p is pointing to s2 then 
       - if s2 is non empty then pop all elements from s2 and push them onto s1 as they are getting popped out.
           Now perform a peek operation on s1 and print the returned element.  Set p to point to s1.

   Time Complexity:  O(n) //In worst case we end up popping an entire stack.
   Space Complexity: O(1) //number of dynamically allocated variables remain constant for any input.

*/

using System;
using System.Collections.Generic;

class Solution
{
    static void Main(String[] args)
    {
        var numberOfQueries = int.Parse(Console.ReadLine());
        var stack1 = new Stack<int>();
        var stack2 = new Stack<int>();
        var queueFrontStack1 = false;

        for (int i = 0; i < numberOfQueries; i++)
        {
            var inputSplits = Console.ReadLine().Split(' ');
            var queryType = int.Parse(inputSplits[0]);
            switch (queryType)
            {
                case 1:
                    if (stack1.Count == 0 && stack2.Count == 0)
                    {
                        stack1.Push(int.Parse(inputSplits[1]));
                        queueFrontStack1 = true;
                    }
                    else
                        stack2.Push(int.Parse(inputSplits[1]));

                    break;
                case 2:
                    if (queueFrontStack1 == true)
                    {
                        stack1.Pop();
                        if (stack2.Count != 0 && stack1.Count == 0)
                            queueFrontStack1 = false;
                    }
                    else
                    {
                        if (stack2.Count > 0)
                        {
                            while (stack2.Count > 1)
                                stack1.Push(stack2.Pop());

                            stack2.Pop();
                            queueFrontStack1 = true;
                        }

                    }
                    break;
                case 3:
                    if (queueFrontStack1 == true)
                        Console.WriteLine(stack1.Peek());
                    else
                    {
                        if (stack2.Count > 0)
                        {
                            while (stack2.Count > 0)
                                stack1.Push(stack2.Pop());

                            queueFrontStack1 = true;
                            Console.WriteLine(stack1.Peek());
                        }

                    }
                    break;
            }
        }
    }
}