/*
 Problem: https://www.hackerrank.com/challenges/jim-and-the-orders/problem
 C# Language Version: 6.0
 .NET Framework Version: 4.7
 Tool Version : Visual Studio Community 2017
 Thoughts (Key points in algorithm) :
 - It is a simple sorting problem. I used quick sort to come up with O( n log(n)) time complexity.
 - The list to be sorted need to maintain two attributes for each customer namely customer number and time of delivery (= orderNumber + serveTime)
 - All the sorting has to be done on the basis of time of delivery.


 Gotchas:
   - Initially, I had implemented the solution using ValueTuple in C#. (int TimeOfDelivery, int CustomerNumber)
     But, execution environment of hackerrank is not up-to-date with C# v7.0 features so I had to create a class instead.

 Time Complexity:  O(n log (n)) //used quick sort.
 Space Complexity: O(n) //We need to store the customers numbers and the time of delivery value in a list for sorting.

*/

using System.Collections.Generic;
using System.Linq;
using System;

class Solution
{
    static void Main(string[] args)
    {
        var customerCount = int.Parse(Console.ReadLine());
        var customers = new List<Customer>();
        for (var i = 1; i <= customerCount; i++)
        {
            var userInputSplits = Console.ReadLine().Split(' ');
            var orderNumber = int.Parse(userInputSplits[0]);
            var serveTime = int.Parse(userInputSplits[1]);
            customers.Add(new Customer { TimeOfDelivery = orderNumber + serveTime, CustomerNumber = i });
        }
        customers = QuickSortCustomers(customers);
        foreach (var customer in customers)
        {
            Console.Write(customer.CustomerNumber);
            Console.Write(" ");
        }
    }

    static List<Customer> QuickSortCustomers(List<Customer> inputList)
    {
        var pivot = inputList[0];
        var smallerItems = new List<Customer>();
        var equalItems = new List<Customer>();
        var biggerItems = new List<Customer>();
        var sortedList = new List<Customer>();

        equalItems.Add(inputList[0]);

        for (var i = 1; i < inputList.Count; i++)
        {
            if (inputList[i].TimeOfDelivery < pivot.TimeOfDelivery)
                smallerItems.Add(inputList[i]);
            else if (inputList[i].TimeOfDelivery > pivot.TimeOfDelivery)
                biggerItems.Add(inputList[i]);
            else
            {
                var itemToBeInserted = inputList[i];
                equalItems.Add(itemToBeInserted);
            }
        }

        if (smallerItems.Count > 1)
            smallerItems = QuickSortCustomers(smallerItems);

        if (biggerItems.Count > 1)
            biggerItems = QuickSortCustomers(biggerItems);

        sortedList.AddRange(smallerItems);
        sortedList.AddRange(equalItems);
        sortedList.AddRange(biggerItems);

        return sortedList;
    }

}

public class Customer
{
    public int TimeOfDelivery { get; set; }
    public int CustomerNumber { get; set; }
}