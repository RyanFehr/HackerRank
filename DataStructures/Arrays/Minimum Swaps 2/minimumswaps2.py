#!/bin/python3

import math
import os
import random
import re
import sys

# Complete the minimumSwaps function below.
def minimumSwaps(arr):
    swaps=0
    dict={}
    for i in range(0,len(arr)):
        dict[arr[i]]=i
       
    for i in range(0,len(arr)):
        if arr[i]==i+1:
            continue
        else:
        
            elem=arr[i]
            arr[i],arr[dict.get(i+1)]=arr[dict.get(i+1)],arr[i]
            dict[elem]=dict[arr[i]]
            dict[arr[i]]=i

           
            swaps=swaps+1
           
    return swaps


        

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    n = int(input())

    arr = list(map(int, input().rstrip().split()))

    res = minimumSwaps(arr)

    fptr.write(str(res) + '\n')

    fptr.close()