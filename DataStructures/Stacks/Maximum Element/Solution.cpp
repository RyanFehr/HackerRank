/*
	Problem: https://www.hackerrank.com/challenges/maximum-element/problem
	Language : C++
	Tool Version : Visual Studio Community 2017
	Thoughts :
	
	1. Let the maximum element present in stack be max. Initialize max to 0.
	2. Start a loop to process next queries:
		2.1 Next query push: 
			- Let the new element be e. 
			- If e > max then set max = e. 
			- Push e to top of the stack. 
			- Increment top of stack by 1.
		2.2 Next query Delete:
			- If element at top of stack is not same as max then remove the element from top of stack and decrement top of stack by 1.
			- If element at top of stack is same as max then
				- Remove the element from top of stack and decrement top of stack by 1.
				- Set max to 0.
				- Scan the remaining stack and set max to the highest element present in remaining stack.
		2.3 Next query print:
			- Print the element at the top of the stack.

	Time Complexity:  Push operation - O(1), Delete operation - O(n), Print Operation - O(1)
	Space Complexity: Push operation - O(1), Delete operation - O(1), Print Operation - O(1) //number of dynamically allocated variables remain constant for any input.

*/


int main() {

    	long stack[100000];
		int queryType = 0;
		int numberOfQueries = 0;
		long topOfStack = -1;
		long iterator = 0;
		long numberToBeInserted = 0;
		long maximumNumber = 0 ;

		scanf("%d", &numberOfQueries);

		while (numberOfQueries > 0)
		{
			//scan query type
			scanf("%d", &queryType);
			//do stack operations
			switch (queryType)
			{
			case 1:
				//push
				scanf("%ld", &numberToBeInserted);
				if (numberToBeInserted > maximumNumber)
					maximumNumber = numberToBeInserted;
				stack[++topOfStack] = numberToBeInserted;
				break;
			case 2:
				//delete
				if (stack[topOfStack] == maximumNumber)
				{
					topOfStack--;
					//current maximum is going to get deleted. We need to set up a new maximum by scanning the stack
					maximumNumber = 0;
					iterator = topOfStack;
					while (iterator > -1)
					{
						maximumNumber = stack[iterator] > maximumNumber ? stack[iterator] : maximumNumber;
						iterator--;
					}
				}
				else
					topOfStack--;
				break;
			case 3:
				//print maximum element
				printf("%ld\n", maximumNumber);
				break;
			}
			numberOfQueries--;
		}
    return 0;
}
