# Time Conversion (Link: https://www.hackerrank.com/challenges/time-conversion/problem)

time = input()
hour = int(time[0]+time[1])
if(time[8] == 'A'):
    if(hour == 12):
        hour = "00"
    elif(hour < 10):
        hour = "0" + time[1]
else:
    if(hour == 12):
        hour == "12"
    else:
        hour = 12+hour

print("{}{}".format(hour, time[2:8]))
