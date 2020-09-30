#!/bin/python3

import math
import os
import random
import re
import sys

# Complete the minimumBribes function below.
def minimumBribes(q):
    bribes = 0
    for i in range(len(q)-1,-1,-1):
        if q[i] - (i + 1) > 2:
            print('Too chaotic')
            return
        if 0 > q[i]-2:
            arr=q[0:i+1]
        else:
            arr=q[q[i]-2:i+1]
        for item in arr:
            if item > q[i]:
                bribes+=1
    print(bribes)

            
  
    
   



if __name__ == '__main__':
    t = int(input())

    for t_itr in range(t):
        n = int(input())

        q = list(map(int, input().rstrip().split()))

        minimumBribes(q)