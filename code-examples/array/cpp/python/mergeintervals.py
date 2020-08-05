#Given a collection of intervals, merge all overlapping intervals.
# leetcode problem:
#https://leetcode.com/problems/merge-intervals/
#Greedy algorithm ----> sort based on start time


arr = [[1,3],[2,6],[8,10],[15,18]]
result = []


#Sort the arr based on the start time
#Sort--> in place

arr.sort(key = lambda x:x[0])

for interval in arr:
    if not result or result[-1][1] < interval[0]:
        result.append(interval)
    else:
        result[-1][1] = max (result[-1][1], interval[1])

print(result)

