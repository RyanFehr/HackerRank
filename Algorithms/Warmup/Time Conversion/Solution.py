# https://www.hackerrank.com/challenges/time-conversion

# !/bin/python3
import sys


def pm(x):
    x = x[:8]
    x = x.split(":")
    if x[0] != "12":
        x[0] = str(int(x[0]) + 12)

    print(":".join(x))


time = input()
if time[-2] == "P":
    pm(time)
else:
    time = time[:8]
    time = time.split(":")
    if time[0] == "12":
        time[0] = "00"
    time = ":".join(time)
    print(time)