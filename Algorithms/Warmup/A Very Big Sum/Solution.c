//Problem: https://www.hackerrank.com/challenges/a-very-big-sum
//C
#include <math.h>
#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#include <assert.h>
#include <limits.h>
#include <stdbool.h>

long int aVeryBigSum(int n, long int* ar) {
    // Complete this function
    int i;
    long int sum = 0;
    for(i = 0; i < n; i++){
        sum = sum + ar[i];
    }
    return sum;
}

int main() {
    int n, i; 
    scanf("%i", &n);
    long int *ar = malloc(sizeof(long int) * n);
    for(i = 0; i < n; i++){
       scanf("%li",&ar[i]);
    }
    long int result = aVeryBigSum(n, ar);
    printf("%ld\n", result);
    return 0;
}
