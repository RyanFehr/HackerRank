#include<bits/stdc++.h>
using namespace std;

long coinChange(long amount, long coins[], long m) {
    long dp[m+1][amount+1];

    for(long i=0; i<=m; i++) 
        dp[i][0] = 1;

    for(long j=1; j<=amount; j++) 
        dp[0][j] = 0;

    for(long i=1; i<=m; i++){
        for(long j=1; j<=amount; j++){
            if(coins[i-1] <= j) 
                dp[i][j] = dp[i-1][j] + dp[i][j - coins[i-1]];
            else 
                dp[i][j] = dp[i-1][j];
        }
    }

    return dp[m][amount];
}

int main() {
    long n, m;
    scanf("%ld %ld", &n, &m);
    long coins[51];
    for(long i=0; i<m; i++) 
        scanf("%ld", &coins[i]);

    long ans = coinChange(n, coins, m);
    printf("%ld\n", ans);

    return 0;
}