//Problem: https://www.hackerrank.com/challenges/birthday-cake-candles
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
int main(){
    long int n, great, temp, count;
    scanf("%li",&n);
    long int height[n];
    int i;
    count = 1;
    for(i=0;i<n;i++)
    {
        scanf("%li",&height[i]);
    }
    great = height[0];
    for(i=0;i<n-1;i++)
    {
        if(great<height[i+1])
            great = height[i+1];
        else if(great==height[i+1])
            count++;
    }
    printf("%li",count);
    return 0;
}