//Problem: https://www.hackerrank.com/challenges/balanced-brackets
//Java 8
/*
First we know that for every opening sequence we need a closing sequence
Because they are in order we need some way to store them in order
For this we could use a stack or possibly a linked list
I think it would be better to use a stack since it offers us the ability
to quickly add remove, and check without messy code

So using a stack all we need to do is to keep track of the
order in which we are expecting our exit sequences
If that order is ever broken then we know the answer is no

edge cases:
    if we have an extra pening sequence and nothing on the stack
    make sure not to pop or peek instead if empty answer is no
    
if we reach the end of sequence and have an empty stack then
answer is yes, otherwise answer is no

*/

import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int t = in.nextInt();
        tests:
        for(int a0 = 0; a0 < t; a0++){
            String s = in.next();
            Stack<Character> stack = new Stack<>();
            
            for(char c : s.toCharArray())
            {
                if(c == '(')
                    stack.push(')');
                else if(c == '{')
                    stack.push('}');
                else if(c == '[')
                    stack.push(']');
                
                else{
                    if( stack.isEmpty() || c != stack.peek()){
                        System.out.println("NO");
                        continue tests;    
                    }
                    else{
                        stack.pop();
                    }
                }
            }
            if(stack.isEmpty())
                System.out.println("YES");
            else
                System.out.println("NO");
        }
    }
}
