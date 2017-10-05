# https://www.hackerrank.com/challenges/mini-max-sum

arr = list(map(int, input().strip().split(' ')))

arr.sort()
ls = [str(sum(arr[0:4])), str(sum(arr[1:5]))]
print(" ".join(ls))
