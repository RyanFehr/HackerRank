#!/bin/python3
'''
Problem: https://www.hackerrank.com/challenges/richie-rich
Python 3

Thoughts: Not a problem with elegant solution. 
Lots of edge cases and if else's required. 
First pass turning the string into palindrome by 
converting mismatch digit to larger of the two mismatch digits.
marking with '-' to keep track of flipped digits.

Taking second pass to maximise the number, turning digits to '9'
and keeping track of number of flips based on already flipped count.

Time Complexity:  O(N)
Space Complexity: O(N)
'''
import sys


n,k = input().strip().split(' ')
n,k = [int(n),int(k)]
num = input().strip()

def make_palin(n, k, number):
    number_str = str(number)
    number = [number_str[i] for i in range(len(number_str))]
    if n == 1 and k > 0:
        print('9')
        return
    for i in range(int(n/2)):
        if number[i] != number[n-i-1]:
            max_num = max(int(number[i]),int(number[n-i-1]))
            number[i] = str(-1 * max_num)
            number[n-i-1] = str(max_num)
            k = k-1
            if k<0 :
                print('-1')
                return
    flips_available = k
    for i in range(int(n/2)):
        dig_1 = int(number[i])
        dig_2 = int(number[n-i-1])
        if dig_1 < 0 and flips_available > 0:
            decrement = 1
            if dig_2 == 9:
                decrement = 0
            number[i] = str(9)
            number[n-i-1] = str(9)
            flips_available = flips_available - decrement
        elif flips_available > 0:
            decrement = 2
            if dig_1 == 9:
                decrement = decrement - 1
            if dig_2 == 9:
                decrement = decrement - 1
            if flips_available >= decrement:
                number[i] = str(9)
                number[n-i-1] = str(9)
                flips_available = flips_available - decrement
        elif dig_1 < 0 and flips_available <= 0:
            number[i] = str(-1 * dig_1)
    if n%2 != 0 and flips_available>0:
        number[int(n/2)] = str(9)
    print(''.join(number))


make_palin(n , k, num)