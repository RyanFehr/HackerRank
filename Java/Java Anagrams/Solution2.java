
//Two strings  and  are called anagrams if they consist same characters, but may be in different orders. So the list of anagrams of  is .
//
//Given two strings, print Anagrams if they are anagrams, print Not Anagrams if they are not. The strings may consist at most  English characters; the comparison should NOT be case sensitive.
//
//This exercise will verify that you can sort the characters of a string, or compare frequencies of characters.
//
//
//
//Sample Input 0
//
//anagram
//margana

//Sample Output 0
//
//Anagrams



//Sample Input 1
//
//anagramm
//marganaa

//Sample Output 1:
//
//Not Anagrams



// this is a optimised solution for solving Anagram problems

import java.util.*;

public class HelloWorld{

     public static void main(String []args){
        
        String str1 = "hello";   // Input 1
        String str2 ="olleh";    // Input 2
        
        boolean Anagram = true;  // Here firstly our Anagram is set to True state
        
        // We all know that there are 256 ASCII differnt characters
        
        int arr1[] = new int[256];   // created arr1 
        int arr2[] = new int[256];   // created arr2
        
        for(char char1:str1.toCharArray()){       //converted str1 string to character Array
            int index = (int)char1;               // here the position of character in the Array are incremented 
            arr1[index]++;
        }
        
        for(char char2:str2.toCharArray()){      //converted str1 string to character Array
            int index = (int)char2;              // here the position of character in the Array are incremented
            arr2[index]++;
        }
        
        for(int i = 0 ; i < 256 ; i++){           
            if(arr1[i] != arr2[i]){              //here the incremented positions in the Arrays are being checked . It also helps us to check characters , numbers , symbols , tec
                Anagram = false;                 // if not Anagram is set to false
                break;
            }
        }
        if(Anagram){
            System.out.println("Is an Anagram");
        }
        else{
            System.out.print("Not an Anagram");
        }
        
     }


     // this a very optimised solution to use.
}