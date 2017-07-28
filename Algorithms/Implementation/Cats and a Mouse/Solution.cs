/*
         Problem: https://www.hackerrank.com/challenges/cats-and-a-mouse/problem
         C# Language Version: 6.0
         .Net Framework Version: 4.5.2
         Thoughts :
         1. Get the next set of location for cat A, cat B and the mouse
         2. In the current set, let location of cat A be catALocation, location of cat B be catBLocation, location of mouse be mouseLocation
         3. Now we simply need to compare the proximity of mouse with cat A and cat B.
            There are below possibilities of locations of cat A, cat B and mouseLocation on x-axis
            - cat A cat B Mouse
            - cat A Mouse cat B
            - mouse Cat A Cat B
            - cat B cat A Mouse
            - cat B Mouse cat A
            - mouse Cat B Cat A
            - Cat A and Cat B at exactly same location
         4. If cat A is found to be nearer to mouse then print "Cat A"
         5. If cat B is found to be nearer to mouse then print "Cat B"   
         6. If both cats are equidistant from mouse then print "Mouse C"
         7. Repeat step 1 to 6 for all set of input locations.
         Time Complexity:  O(n)
         Space Complexity: O(1)
                
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) 
    {

        var output = "Mouse C";
            var q = int.Parse(Console.ReadLine());
            for (int a0 = 0; a0 < q; a0++)
            {
                var tokens_x = Console.ReadLine().Split(' ');
                var catALocation = int.Parse(tokens_x[0]);
                var catBLocation = int.Parse(tokens_x[1]);
                var mouseLocation = int.Parse(tokens_x[2]);

                if (catALocation < catBLocation)
                {
                    if (catBLocation <= mouseLocation)
                    {
                        //cat A cat B Mouse
                        output = "Cat B";
                    }
                    else
                    {
                        if (mouseLocation > catALocation)
                        {
                            //cat A Mouse cat B
                            if (mouseLocation - catALocation > catBLocation - mouseLocation)
                                output = "Cat B";
                            else if (mouseLocation - catALocation < catBLocation - mouseLocation)
                                output = "Cat A";
                            else
                                output = "Mouse C";
                        }
                        else
                        {
                            //mouse Cat A Cat B
                            output = "Cat A";
                        }

                    }

                }
                else if (catALocation > catBLocation)
                {
                    if (catALocation <= mouseLocation)
                    {
                        //cat B cat A Mouse
                        output = "Cat A";
                    }
                    else
                    {
                        if (mouseLocation > catBLocation)
                        {
                            //cat B Mouse cat A
                            if (catALocation - mouseLocation > mouseLocation - catBLocation)
                                output = "Cat B";
                            else if (catALocation - mouseLocation < mouseLocation - catBLocation)
                                output = "Cat A";
                            else
                                output = "Mouse C";
                        }
                        else
                        {
                            //mouse Cat B Cat A
                            output = "Cat B";
                        }

                    }
                }
                else
                {
                    //cat fight will let the mouse run-away.
                    output = "Mouse C";
                }

                Console.WriteLine(output);
            }
        
    }
}
