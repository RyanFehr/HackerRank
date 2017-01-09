//Problem: https://www.hackerrank.com/challenges/java-static-initializer-block
//Java 7
static Scanner input = new Scanner(System.in);
static int B = input.nextInt();
static int H = input.nextInt();
static Boolean flag = B > 0 && H > 0;

static{
        if(!flag){
            System.out.println("java.lang.Exception: Breadth and height must be positive");
        }
}
