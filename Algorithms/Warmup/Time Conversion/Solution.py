#Problem: https://www.hackerrank.com/challenges/time-conversion
#Python 3
#!/bin/python3

import os
import sys

#
# Complete the timeConversion function below.
#
def timeConversion(s):
    #
    # Write your code here.
    #
    if s[8] == 'A' :
        if s[0] == '1' and s[1] == '2':
            res = '00:'+ s[3:8]
            return res
        else:
            res =  s[0:8]
            return res
    else:
        if s[0] == '1' and s[1] == '2':
            res = '12:'+ s[3:8]
            return res
        else:
            res =  s[0:2]
            res = int(res) + 12
            res = str(res) + s[2:8]
            return res

if __name__ == '__main__':
    f = open(os.environ['OUTPUT_PATH'], 'w')

    s = input()

    result = timeConversion(s)

    f.write(result + '\n')

    f.close()
