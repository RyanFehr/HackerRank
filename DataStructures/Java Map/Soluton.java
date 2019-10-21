/**
* https://www.hackerrank.com/challenges/phone-book/problem
**/

import java.util.*;
import java.io.*;

class JavaMap{
	public static void main(String []argh)
	{
        Scanner in = new Scanner(System.in);
        int n=in.nextInt();
        in.nextLine();
        HashMap<String,Integer> data = new HashMap<>();
        for(int i=0;i<n;i++)
        {
            String name=in.nextLine();
            int phone=in.nextInt();
            in.nextLine();
            data.put(name, phone);
        }
        while(in.hasNext())
        {
            String key=in.nextLine();
            if (data.containsKey(key)){
                System.out.println(key + "=" + data.get(key));
            }else{
                System.out.println("Not found");
            }
        }
	}
}



