'''
Problem: https://www.hackerrank.com/challenges/coin-change
Python 3

Thoughts: Recursive solution for the intuition.
Recursing through the possibilty of solution with nth coin 
and without nth coin. 
Bottom up DP to track overlapping subproblem solution.

Time Complexity:  O(N*M)
Space Complexity: O(N)
'''



N,M = list(map(int,input().strip().split(' ')))
coins = list(map(int,input().strip().split(' ')))

count = 0
def count_make_change_recursive(N, coins, M):
    if N < 0:
        return 0
    if N == 0:
        return 1
    if M <= 0:
        return 0
    return count_make_change(N-coins[M-1], coins, M) + count_make_change(N,coins,M-1)


def count_make_change_bottom_up(N, coins, M):
    counts = [0] * (N+1)
    counts[0] = 1
    for i in range(0, M):
        sum = 0
        for j in range(coins[i],N+1):
            counts[j] += counts[j-coins[i]]
    return counts[N]


print(count_make_change_bottom_up(N,coins,M))