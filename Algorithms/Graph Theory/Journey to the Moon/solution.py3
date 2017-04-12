'''
Problem: https://www.hackerrank.com/challenges/journey-to-the-moon
Python 3

Thoughts: Using Quick Find approach to build 
Connected componenets. Basically each Connected 
Componenet is a Country. Number of nodes in each component
is number of people in each country. 
Using a counts array and an iteration over connected components
array to get count of people in each country.
Simple Mathematics to get total possibilities.

Time Complexity:  O(N + I)
Space Complexity: O(N)
'''

N,P = list(map(int,input().strip().split(' ')))
connections = [-1] * N


'''Basic way of storing connected components for quick find.'''
def connect_quick_find(connections, u, v):
    if connections[u] > -1 and connections[v] == -1:
        connections[v] = connections[u]
        return
    if connections[v] > -1 and connections[u] == -1:
        connections[u] = connections[v]
        return
    if connections[u] > -1 and connections[v] > -1:
        connect_to = min(connections[u], connections[v])
        connect_it = connections[v]
        for i in range(len(connections)):
            if connections[i] == connect_it:
                connections[i] = connections[u]
        return 
    connections[u] = u
    connections[v] = u
    return


for a0 in range(P):
    u,v = input().strip().split(' ')
    u,v = [int(u),int(v)]
    connect_quick_find(connections,u,v)


'''Preparing a counts array of number of nodes in each connected component i.e number of persons in each country.'''
counts = [0] * N
for i in range(len(connections)):
    if connections[i] == -1:
        connections[i] = i
    counts[connections[i]] = counts[connections[i]] + 1
combinations = 0
sum = 0


'''calculating combination'''
for i in range(len(counts)-1,-1,-1):
    combinations = combinations + abs(counts[i])*sum
    sum = sum + abs(counts[i])

print(combinations)
