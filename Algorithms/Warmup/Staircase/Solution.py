# https://www.hackerrank.com/challenges/staircase

space = " "
hashtag = "#"
answer = ""
n = int(input().strip())
for i in range(1, n+1):
    answer += (space*(n-i))+(hashtag * i)
    print(answer)
    answer = ""
