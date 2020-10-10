#!/bin/python3

import math
import os
import random
import re
import sys

def repeatedString(s, n):
    mul = n // len(s)
    space = n - mul * len(s)
    st1 = s[:space]
    count = 0
    count1 = 0
    for i in s:
        if i == 'a':
            count += 1
    for i in st1:
        if i == 'a':
            count1 += 1
    nm = (mul * count) + count1

    return nm

    
if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    s = input()

    n = int(input())

    result = repeatedString(s, n)

    fptr.write(str(result) + '\n')

    fptr.close()
