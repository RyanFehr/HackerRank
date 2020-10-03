#include <bits/stdc++.h>

using namespace std;

int main() { int i,n,k; float median; cin >> n;

vector<int>my;

for(i=0;i<n;i++)
{
    cin >> k;

    if(i == 0)
    {
        cout<<k<<".0"<<endl;
        my.push_back(k);
        continue;
    }

    vector<int>::iterator pos;

    pos = upper_bound(my.begin(),my.end(),k);
    my.insert(pos,k);

    /*for(int j=0;j<my.size();j++)
        cout<<my.at(j)<<" ";*/

    int p = my.size();
    //cout<<p<<endl;

    int u = p/2;

    if(p&1)
    {
        median = (float)my.at(u);
        cout<<fixed<<setprecision(1)<<median<<endl;
        continue;
    }

    else
    {

        median = (float)( my.at(u - 1) + my.at(u) ) / 2;
        //cout<<my.at(u-1)<<" "<<my.at(u)<<endl;
        cout<<fixed<<setprecision(1)<<median<<endl;
        continue;
    }

}

return 0;
}
