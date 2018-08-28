#!/bin/python3

def pageCount(n, p):
    # if start from page 1, pageCount will be just p//2 since each flip shows 2 pages, 
    # if start from page n, pageCount will be (n//2 - p//2) to reach page p.
    return min(p//2, n//2 - p//2)

if __name__ == '__main__':
    n = int(input())
    p = int(input())
    print(pageCount(n, p))
