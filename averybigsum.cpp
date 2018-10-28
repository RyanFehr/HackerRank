#include<iostream>
using namespace std;
int main()
{
    int n; long long int A[10],sum=0; int i=0;
    cin>>n;
    for(i=0;i<n;i++)
    {
        cin>>A[i];
        sum+=A[i];
    }
    cout<<sum;
    return 0;
}
