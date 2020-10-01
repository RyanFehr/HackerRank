#include<iostream>
using namespace std;
int main()
{
    int i;
    int n,d;
    cin>>n>>d;
    int arr[n];
    int brr[n];
    for(i=0;i<n;i++)
    {
        cin>>arr[i];
    }
    for(i=0;i<n;i++)
    {
        if(d>i)
        brr[i-d+n]=arr[i];
        else
        brr[i-d]=arr[i];
    }
    for(i=0;i<n;i++)
    cout<<brr[i]<<' ';
return 0;
}
