//Problem: https://www.hackerrank.com/challenges/plus-minus
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
    int n, i, neg=0, pos=0, zero=0;
    double fpos, fneg, fzero;
    scanf("%d",&n);
    int arr[n];
    for(i=0;i<n;i++)
    {
        scanf("%d",&arr[i]);
    }
    for(i=0;i<n;i++)
    {
        if(arr[i]>0)
            pos++;
        else if(arr[i]<0)
            neg++;
        else
            zero++;
    }
    fpos = (double)pos/n;
    fneg = (double)neg/n;
    fzero = (double)zero/n;
    printf("%lf\n%lf\n%lf", fpos, fneg, fzero);
    return 0; 
}