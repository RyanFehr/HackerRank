/*
    Problem : https://www.hackerrank.com/challenges/sherlock-and-array
    C++ 14
    Approach : 
        This is quite a straight forward problem. All elements of the input array is
        set to the sum of all the elements upto that point of the input array, i.e.
        arr[i] = Sum(arr[j]) for 0 <= j <=i < n
        Then in an other loop we compare arr[i] and arr[n-1] - arr[i] , which will 
        turn the answer to be YES, otherwise it is NO. 
        
    Time Complexity : O( n ) for each test case. 
    Overall Time Complexity : O( t*n ) for entire input file.
    Space Complextiy : O( n ) for entire input file.
*/
#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
using namespace std;

int main() {
    /* Enter your code here. Read input from STDIN. Print output to STDOUT */   
    int test; cin>>test;
    int n=100000, i=0, temp=0; 
    unsigned long long arr[n], sum=0;
    while(test--){
        for(i=0; i<=100000; i++){
            arr[i]=0;
        }
        cin>>n;
        for(i=0; i<n; i++){
            cin>>temp;
            sum+=temp;
            arr[i]=sum;
            temp=0;
        }
        if(n==1){
            cout<<"YES\n";
            sum=0;
            continue;
        }
        for(i=1; i<n; i++){
            if(arr[i-1]==(arr[n-1]-arr[i])){
                cout<<"YES\n";
                break;
            }
            else
                continue;
        }
        if(i==n)
            cout<<"NO\n";
        sum=0;
    }
    return 0;
}
