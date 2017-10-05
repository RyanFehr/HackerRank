# https://www.hackerrank.com/challenges/diagonal-difference

#!/bin/python3

matrix_size = int(input())

current_x_one = 0
current_x_two = matrix_size - 1

sum_one = 0
sum_two = 0

for line in range(matrix_size):
    input_string = input().split(" ")
    sum_one = sum_one + int(input_string[current_x_one])
    sum_two = sum_two + int(input_string[current_x_two])

    current_x_one += 1
    current_x_two -= 1

print(abs(sum_one - sum_two))