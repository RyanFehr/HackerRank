# https://www.hackerrank.com/challenges/simple-array-sum

def simple_array_sum(n, ar):
    # Complete this function
    a = 0
    for i in ar:
        a += i
    return a


n = int(input().strip())
ar = list(map(int, input().strip().split(' ')))
result = simple_array_sum(n, ar)
print(result)
