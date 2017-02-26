//Problem: https://www.hackerrank.com/challenges/game-of-thrones
//Java 8
/*
A palindrome has the unique property that
the frequency of only one character can
be odd, so we can simply count the
frequency of characters and check if
there is more than 1 that is odd

Example:
aaabbbb

a: 3
b: 4
1 odd

cdefghmnopqrstuvw
c:1
d:1
e:1
f:1
g:1
h:1
m:1
n:1
o:1
p:1
q:1
r:1
s:1
t:1
u:1
v:1
w:1
18 odds

cdcdcdcdeeeef
c:4
d:4
e:4
f:1
1 odd

Time Complexity: O(n) //In the size of the string
Space Complexity: O(1) //We have a fixed number of different characters


*/


import java.io.*;
import java.util.*;

public class Solution {

    public static void main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution. */
        Scanner input = new Scanner(System.in);
        String s = input.nextLine();
        
        Map<Character, Integer> letters = new HashMap<>();
        for(char c : s.toCharArray())
        {
            if(letters.containsKey(c))
                letters.put(c, letters.get(c) + 1);
            else
                letters.put(c, 1);
        }
        
        int odd = 0;
        int even = 0;
        for(Integer frequency : letters.values())
        {
            if(frequency % 2 == 1)
            {
                odd++;
                continue;
            }
                
            if(frequency % 2 == 0)
                even++;
        }
        
        if(odd > 1) 
            System.out.println("NO");
        else
            System.out.println("YES");
        
    }
}