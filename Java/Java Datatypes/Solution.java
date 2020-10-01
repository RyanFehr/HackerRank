import java.util.Scanner;

class Solution{
    public static void main(String []args)
    {
        Scanner sc = new Scanner(System.in);
        int t = sc.nextInt();

        while(t-- > 0)
        {
            try
            {
                long x = sc.nextLong();
                System.out.println(x + " can be fitted in:");

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
                
            }
            catch(Exception e)
            {
                System.out.println( sc.next() + " can't be fitted anywhere.");
            }

        }
    }
}
