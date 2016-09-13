package strings;


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





import java.io.*;
import java.util.*;

public class Solution {
	
	 //My hash map is intialized based on the fact that this is only using english characters

	//Overall time complexity: O(n)
	//Overall space complexity: O(n)

	static boolean isAnagram(String a, String b)
  {
      boolean anagram = true;
      Character[] charSet =   {'A','B','C','D','E',
                            'F','G','H','I','J',
                            'K','L','M','N','O',
                            'P','Q','R','S','T',
                            'U','V','W','X','Y','Z'};
      HashMap<Character,Integer> ALetterFrequency = new HashMap<Character,Integer>();
      HashMap<Character,Integer> BLetterFrequency = new HashMap<Character,Integer>();
      intializeHash(ALetterFrequency, charSet);       //O(n)
      intializeHash(BLetterFrequency, charSet);       //O(n)
      a = a.toUpperCase(); //O(n)
      b = b.toUpperCase(); //O(n)
      
      //I wrote my strings into arrays costing me in space complexity because if you do like I show 
      //below you will have a time complexity of O(n^2), because substring has a time complexity of O(n) 
      //ever since it was changed in Java 7.6 but I did trade of space complexity of O(1) to achieve this:
      
      //for(int i = 0;i <a.length();i++)  //O(n)
      //{
      //    String letter = letterFrequencya.substring(i,i+1);   //O(n)
      //    letterFrequency.put(letter,letterFrequency.get(letter)++);
      //}
      
      
      char[] AcArray = a.toCharArray();
      char[] BcArray = b.toCharArray();
      Character[] AArray = toCharacterArray(AcArray); //O(n)
      Character[] BArray = toCharacterArray(BcArray); //O(n)
      
      for(int i = 0; i<AArray.length;i++) //O(n)
      {
          Character letter = AArray[i]; //O(1)
          Integer frequency = ALetterFrequency.get(letter);//O(1)
          ALetterFrequency.put(letter,++frequency); //O(1)
      }
      
      for(int i = 0; i<BArray.length;i++)
      {
          Character letter = BArray[i]; //O(1)
          Integer frequency = BLetterFrequency.get(letter); //O(1)
          BLetterFrequency.put(letter,++frequency); //O(1)
      }
      
      //Compare Hash
      for(Character letter : charSet)
      {
          if(!ALetterFrequency.get(letter).equals(BLetterFrequency.get(letter)))
          {
              anagram = false;
          }
      }
      
      return anagram;
  }
  static void intializeHash(HashMap hash, Character[] set)
  {
      for(Character letter : set)
     {
          hash.put(letter,0);
     }
          
  }
  static Character[] toCharacterArray(char[] cArray)
  {
      Character[] CArray = new Character[cArray.length];
      for(int i =0; i<cArray.length;i++)
      {
          CArray[i] = (Character) cArray[i];
      }
      return CArray;
  }
	    
	    public static void main(String[] args) {
	        
	        //Scanner scan = new Scanner(System.in);
	        String a = "anagramm";
	        String b = "marganaa";
	        //scan.close();
	        boolean ret = isAnagram(a, b);
	        System.out.println( (ret) ? "Anagrams" : "Not Anagrams" );
	    }

}
