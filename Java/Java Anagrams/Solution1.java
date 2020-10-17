


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





import java.util.*;

public class HelloWorld{

     public static void main(String []args){
        
        // here i am taking two string inputs for comparison
        String str1 = "hello";
        String str2 ="olleh";
        
    
        boolean Anagram = false;   // Firstly our anagram will be initialized to false
        
        boolean[] checked = new boolean[str1.length()];  // A check point is necessary so that a single letter or character cannot be comparisoned two or multiple times
        
        
        
        if(str1.length() == str2.length()){       // If length of both thr string are not the same than i wouldn't be a fair comparison and it will display us Not an Anagram 
        
        for(int i = 0 ; i < str1.length() ; i++){

          char str3 = str1.charAt(i);
          // A separate str3 is created so that a array of characters is created of str1


          Anagram = false;

            for(int j = 0 ; j < str2.length() ; j++){
                if(str2.charAt(j) == str3 && !checked[j] ){   // if character at str2 is == str3 and is not checked
                checked[j] = true;                            // than character is changed to checked state
                Anagram = true;                               // and Anagram is changed to true state 
                break;
                }
            }
            if(!Anagram){                                     // if there is any unsimilar character than Anagram is changed to false and the loop is breaked
                break;
            }
          }
        }
        if(Anagram){
            System.out.println("Is an Anagram");
        }
        else{
            System.out.print("Not an Anagram");
        }
        
     }
}





