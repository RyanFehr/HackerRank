//Problem: https://www.hackerrank.com/challenges/compare-the-triplets
//C
#include <math.h>
#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#include <assert.h>
#include <limits.h>
#include <stdbool.h>

void solve(int a0, int a1, int a2, int b0, int b1, int b2, int arr[]){
    // Complete this function
    if(a0>b0){
        arr[0]++;
    }
    if(a1>b1){
        arr[0]++;
    }
    if(a2>b2){
        arr[0]++;
    }
      if(a0<b0){
        arr[1]++;
    }
    if(a1<b1){
        arr[1]++;
    }
    if(a2<b2){
        arr[1]++;
    }
    
}

int main() {
    int i;
    int a0; 
    int a1; 
    int a2; 
    scanf("%d %d %d", &a0, &a1, &a2);
    int b0; 
    int b1; 
    int b2; 
    scanf("%d %d %d", &b0, &b1, &b2);
    int arr[2];
    arr[0]=0;
    arr[1]=0;
    solve(a0, a1, a2, b0, b1, b2, arr);
    for(i = 0; i < 2; i++) {
        if(i) {
            printf(" ");
        }
        printf("%d", arr[i]);
    }
    return 0;
}
