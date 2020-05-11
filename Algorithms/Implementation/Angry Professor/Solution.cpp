#include <bits/stdc++.h>
using namespace std;

int main() {
        int T;
        cin >> T;
         
        while(T--)
        {
            int n, k;
            cin >> n >> k;
            int onTime = 0;
            for(int j = 0; j < n; j++)
            {
                int arrivalTime;
                cin >> arrivalTime;
                if(arrivalTime <= 0)
                {
                    onTime++;
                }
            }
            if(onTime >= k)
            {
                cout << "NO\n";
            }
            else
            {
                cout << "YES\n";   
            }
        }
}
