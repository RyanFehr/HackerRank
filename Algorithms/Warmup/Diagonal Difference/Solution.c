//Problem: https://www.hackerrank.com/challenges/diagonal-difference
//C
#include <math.h>
#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#include <assert.h>
#include <limits.h>
#include <stdbool.h>

int diagonalDifference(int n, int a[n][n]) {
    // Complete this function
    int leftright = 0, rightleft = 0, i, j;
    for(i=0;i<n;i++)
    {
        leftright = leftright + a[i][i];
    }
  
     for(i=0,j=n-1;i<n,j>=0;i++,j--)
    { 
        rightleft += a[i][j];
    }
    return (leftright-rightleft);
}

int main() {
    int n, i, j; 
    scanf("%i", &n);
    int a[n][n];
    for (i = 0; i < n; i++) {
       for (j = 0; j < n; j++) {
          scanf("%i",&a[i][j]);
       }
    }
    int result = diagonalDifference(n, a);
    if(result<0)
        result*=(-1);
    printf("%d\n", result);
    return 0;
}
