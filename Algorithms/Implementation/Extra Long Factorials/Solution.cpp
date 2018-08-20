#include <bits/stdc++.h>
//#include<gmpxx.h>
using namespace std;

void extraLongFactorials(int n) {
    int a[200],i=0,temp=n,c=0;
    for(int i=0;i<200;i++)
    {
        a[i]=0;
    }
    while(n>0)
    {
        a[i]=n%10;
        n/=10;
        i++;
        
    }
    n=temp-1;
    while(n>1)
    {
        for(i=0;i<200;i++)
        {
            a[i]=(a[i]*n)+c;
            c=a[i]/10;
            a[i]%=10;
        }
        n--;
    }
    i=0;
    for(int j=199;j>=0;j--)
    {
        if(a[j]!=0)
            i++;
        if(i!=0)
            cout<<a[j];
    }
}

int main() {
    int n;
    cin >> n;
    extraLongFactorials(n);
    return 0;
}

