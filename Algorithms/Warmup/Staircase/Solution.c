//Problem: https://www.hackerrank.com/challenges/staircase
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

int main()
{
    int n, i, j;
    scanf("%d",&n);
    for(i=0;i<n;i++)
    {
        for(j=0;j<n-i-1;j++)
            printf(" ");
        for(j=0;j<i+1;j++)
            printf("#");
        printf("\n");
    }
    return 0;
}