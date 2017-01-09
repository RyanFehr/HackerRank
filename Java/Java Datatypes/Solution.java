//Problem: https://www.hackerrank.com/challenges/java-datatypes
//Java 7
import java.util.*;
import java.io.*;



class Solution{
    public static void main(String []argh)
    {



        Scanner sc = new Scanner(System.in);
        int t=sc.nextInt();

        for(int i=0;i<t;i++)
        {

            try
            {
                long x=sc.nextLong();
                System.out.println(x+" can be fitted in:");
                try{
                    byte y = (byte) x;
                    if(y == x)
                    {
                        System.out.println("* byte");    
                    }
                }catch(Exception e){}
                try{
                    short y = (short) x;
                    if(y == x)
                    {
                        System.out.println("* short");
                    }
                }catch(Exception e){}
                try{
                    int y = (int) x;
                    if(y == x)
                    {
                        System.out.println("* int");
                    }
                }catch(Exception e){}
                
                
                
                System.out.println("* long");
                //Complete the code
            }
            catch(Exception e)
            {
                System.out.println(sc.next()+" can't be fitted anywhere.");
            }

        }
    }
}