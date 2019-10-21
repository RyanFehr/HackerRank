//Problem: https://www.hackerrank.com/challenges/simple-array-sum
//C
#include <math.h>
#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#include <assert.h>
#include <limits.h>
#include <stdbool.h>

int simpleArraySum(int n, int ar_size, int* ar) {
    // Complete this function
    int result = 0;
    for(n=0;n<ar_size;n++){
        result = result + ar[n];
    }
    
    return result;
}

int main() {
    int n, i, j; 
    scanf("%d", &n);
    int *ar = malloc(sizeof(int) * n);
    for(i = 0; i < n; i++){
       scanf("%i",&ar[i]);
    }
    int result = simpleArraySum(n, n, ar);
    printf("%d\n", result);
    return 0;
}
