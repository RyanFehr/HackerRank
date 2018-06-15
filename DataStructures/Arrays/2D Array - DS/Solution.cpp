/*
	Problem: https://www.hackerrank.com/challenges/2d-array/problem
	Tool Version : Visual Studio Community 2017

	Thoughts :
	- We need to locate the top left index of each hourglass at first to process it.
	- Considering (0,0) position as the topmost leftmost element, we will never find a complete
	hourglass if position goes over (3,3). So we put this as constraint in the iterations.
	- Keep a running total of max sum and reassign it whenever we find an hourglass with bigger sum.

	Time Complexity:  O(1) //The size of the array has been kept fixed at 6 * 6. So, there will
							always be 16 hourglasses in the array. So, although there are nested loops
							the number of iterations are fixed at 16.
	Space Complexity: O(1) //number of dynamically allocated variables remain constant for any combination of
							 6 * 6 input array.
*/

#include <bits/stdc++.h>

using namespace std;

int array2D(vector<vector<int>> arr) {
	int maxSum;
	int tempSum;
	for (int arr_i = 0; arr_i < 6; arr_i++) {
		for (int arr_j = 0; arr_j < 6; arr_j++) {
			tempSum = 0;
			//locate the starting index of each hour glass to work
			if (arr_i < 4 && arr_j < 4)
			{
				//create temp sum of current hour glass
				int tempI = arr_i;
				int tempJ = arr_j;
				tempSum += arr[tempI][tempJ];
				tempJ++;
				tempSum += arr[tempI][tempJ];
				tempJ++;
				tempSum += arr[tempI][tempJ];
				tempI++; tempJ--;
				tempSum += arr[tempI][tempJ];
				tempI++; tempJ--;
				tempSum += arr[tempI][tempJ];
				tempJ++;
				tempSum += arr[tempI][tempJ];
				tempJ++;
				tempSum += arr[tempI][tempJ];
				if (arr_i == 0 && arr_j == 0)
					maxSum = tempSum;
				else if (tempSum > maxSum)
				{
					maxSum = tempSum;
				}
			}
		}
	}
	return maxSum;

}

int main()
{
	ofstream fout(getenv("OUTPUT_PATH"));

	vector<vector<int>> arr(6);
	for (int arr_row_itr = 0; arr_row_itr < 6; arr_row_itr++) {
		arr[arr_row_itr].resize(6);

		for (int arr_column_itr = 0; arr_column_itr < 6; arr_column_itr++) {
			cin >> arr[arr_row_itr][arr_column_itr];
		}

		cin.ignore(numeric_limits<streamsize>::max(), '\n');
	}

	int result = array2D(arr);

	fout << result << "\n";

	fout.close();

	return 0;
}
