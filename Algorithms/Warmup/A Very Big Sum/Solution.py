# https://www.hackerrank.com/challenges/a-very-big-sum

answer = 0

n = int(input().strip())
arr = [int(arr_temp) for arr_temp in input().strip().split(' ')]

for i in arr:
    answer += i
print(answer)
