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

public class Solution {

    static boolean isAnagram(String a, String b){
        a = a.toUpperCase();
        b = b.toUpperCase();
        char[] ar1 = a.toCharArray();
        java.util.Arrays.sort(ar1);
        String sorted1 = String.valueOf(ar1); //sort the chars 

        char[] ar2 =  b.toCharArray();
        java.util.Arrays.sort(ar2);
        String sorted2 = String.valueOf(ar2);  //sort the char 
	    
        return sorted1.equals(sorted2); //Compare the String now 
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
