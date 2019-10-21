//Problem: https://www.hackerrank.com/challenges/mini-max-sum
//C
#include <assert.h>
#include <limits.h>
#include <math.h>
#include <stdbool.h>
#include <stddef.h>
#include <stdint.h>
#include <stdio.h>
#include <stdlib.h>
#include <string.h>

// Complete the miniMaxSum function below.
void miniMaxSum(int arr_count, unsigned int* arr) {
    unsigned int sum = 0;
    unsigned int min = INT_MAX;
    unsigned int max = 0;
    for(int i = 0; i < arr_count; i++) {
        sum += arr[i];
        if(min > arr[i])
            min = arr[i];
        if(max < arr[i])
            max = arr[i];
    }
    printf("%u %u", sum - max, sum - min);
    return;
}

int main() {
    unsigned int arr[5];
    for(int i = 0; i < 5; i++)
        scanf("%u", &arr[i]);
    miniMaxSum(5, arr);
    return 0;
}
