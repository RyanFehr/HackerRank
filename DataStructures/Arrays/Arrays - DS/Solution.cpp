/*
	Problem: https://www.hackerrank.com/challenges/arrays-ds/problem
	Language : C++
	Tool Version : Visual Studio Community 2017
	Thoughts :
	1. Let there by an array containing n integers.
	2. Start a loop. Initialize a counter c to n-1:
		2.1 Print the value in the array at index c.
		2.2 Decrement c by 1.
		2.3 Repeat steps from 2.1 through 2.2 till c >= 0.
	3. End

	Time Complexity:  O(n) //one for loop is present to scan all the input elements
	Space Complexity: O(n) //All elements have to be stored in an array required for printing later on.

	*/

int main(){
    int n; 
    scanf("%d",&n);
    int *arr = static_cast<int*>(malloc(sizeof(int) * n));
    for(int arr_i = 0; arr_i < n; arr_i++){
       scanf("%d",&arr[arr_i]);
    }
    
    for(int counter = n-1; counter >= 0; counter--){
       printf("%d ",arr[counter]);
    }
    return 0;
}
