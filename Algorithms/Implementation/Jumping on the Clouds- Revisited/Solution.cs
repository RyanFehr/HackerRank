/*
    Problem: https://www.hackerrank.com/challenges/jumping-on-the-clouds-revisited
    C# Language Version: 6.0
    .Net Framework Version: 4.7
    Tool Version : Visual Studio Community 2017
    Thoughts :
    1. Store the type (ordinary/thundercloud) of all the clouds in an array. Let there be n clouds.
    2. Let jump size be k.
    3. Initialize total energy E with 100.
    4. Initialize current cloud number, c to 0.
    5. Start an infinitely running loop:
        5.1 Jump to next cloud. Set c to (c + k) % n
        5.2 if cloud number c is ordinary cloud then reduce E by 1.
        5.3 if cloud number c is thundercloud then reduce E by 3.
        5.4 if cloud number c is 0 then quit the infinite loop.
        5.5 Jump to step 5.1
    6. Print E.

    Time Complexity:  O(n)
    Space Complexity: O(n) //We are creating an array of the entire input which is a copy. It will increase with increasing number of clouds.
                
*/
using System;

class Solution
{
    static void Main(String[] args)
    {
        var userInput = Console.ReadLine().Split(' ');
        var numberOfClouds = int.Parse(userInput[0]); //n
        var jumpSize = int.Parse(userInput[1]); //k

        userInput = Console.ReadLine().Split(' ');
        var clouds = new int[numberOfClouds];

        for (int i = 0; i < numberOfClouds; i++)
            clouds[i] = int.Parse(userInput[i]);

        var totalEnergyRemaining = 100;
        var currentCloud = 0;
        while (true)
        {
            //calculate next cloud number after new jump.
            currentCloud = (currentCloud + jumpSize) % numberOfClouds;

            if (clouds[currentCloud] == 1)
                totalEnergyRemaining -= 3;
            else
                totalEnergyRemaining--;

            if (currentCloud == 0)
                break;
        }
        Console.WriteLine(totalEnergyRemaining);
    }
}
