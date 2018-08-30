#!/bin/python3

def getMoneySpent(keyboards, drives, budget):
    keyboards.sort()
    drives.sort(reverse=True)
    
    len_keyboards = len(keyboards)
    len_drives = len(drives)
    money_spent = -1

    i = j = 0
    while i < len_drives:
        while j < len_keyboards:
            if drives[i] + keyboards[j] > budget:
                break
            if drives[i] + keyboards[j] > money_spent:
                money_spent = drives[i] + keyboards[j]
            j += 1
        i += 1
    return money_spent

if __name__ == '__main__':
    b, n, m = map(int, input().split(' '))
    keyboards = list(map(int, input().split()))
    drives = list(map(int, input().split()))
    # The maximum amount of money she can spend on a keyboard and USB drive, or -1 if she can't purchase both items
    print(getMoneySpent(keyboards, drives, b))
