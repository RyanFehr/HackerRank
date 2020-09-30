
n,m=map(int,input().split())

arr = [0 for i in range(n)]

top = 0
x=0

for i in range(m):
    beg,end,val=map(int,input().split())

    arr[beg-1]+=val

    if end<=n-1:
        arr[end]-=val
        
    else:
        pass

for i in range(n):
    x+=arr[i]
    if x > top : top =x

print(top)
    