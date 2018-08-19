#include <bits/stdc++.h>

using namespace std;

vector <int> climbingLeaderboard(vector <int> scores, vector <int> alice) {
    // Complete this function
    vector <int> s(alice.size()),rank;
    int i,j=0,last=scores.size();
    rank.insert(rank.begin(),scores[0]);
    for(i=0;i<scores.size();i++)
    {
            if(rank[j]>scores[i])
            {
                rank.insert(rank.end(),scores[i]);
                j++;
            }
    }
    int k=rank.size()-1;
    last=rank.size()+1;
    for(i=0;i<alice.size();i++)
    {
        s[i]=rank.size()+1;
        for(j=k;j>=0;j--)
        {
            if(alice[i]>rank[j])
            {
                if(j==0)
                    s[i]=1;
                else
                    s[i]=j+1;
            }
            else if(alice[i]==rank[j])
            {
                s[i]=j+1;
            }
            if(rank[j]>alice[i])
            {
                s[i]=last;
                k=last;
                break;
            }
         last=s[i];   
        }
    }
    return s;
}

int main() {
    int n;
    cin >> n;
    vector<int> scores(n);
    for(int scores_i = 0; scores_i < n; scores_i++){
       cin >> scores[scores_i];
    }
    int m;
    cin >> m;
    vector<int> alice(m);
    for(int alice_i = 0; alice_i < m; alice_i++){
       cin >> alice[alice_i];
    }
    vector <int> result = climbingLeaderboard(scores, alice);
    for (ssize_t i = 0; i < result.size(); i++) {
        cout << result[i] << (i != result.size() - 1 ? "\n" : "");
    }
    cout << endl;


    return 0;
}

