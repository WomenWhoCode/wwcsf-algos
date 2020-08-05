#https://leetcode.com/problems/insert-interval/
# 
# 
# #Given a set of non-overlapping intervals, insert a new interval 
# into the intervals (merge if necessary).

#You may assume that the intervals were initially sorted 
# according to their start times.

def insertIntervals(intervals, newInterval):

    if len(newInterval) == 0: 
            return intervals
        
    if len(intervals) == 0 and len(newInterval) > 0:
        return [newInterval]
    
    index1 = -99
    #check the new interval start time and merge with the interval accordingly
    
    for index, i in enumerate(intervals):
        
        if i[0] < newInterval[0]:
            continue
        else:
            index1 = index
            break
            
    if index1 == -99:
        index = len(intervals)
        intervals.insert(index, newInterval)
    else:
        intervals.insert(index, newInterval)
    mergeresult = []
    
    #Check if the current start time coincides with previous end time. if so, merge the intervals
    
    for j in intervals:
        
        if not mergeresult or mergeresult[-1][1] < j[0]:
            mergeresult.append(j)
        else:
            mergeresult[-1][1] = max(mergeresult[-1][1], j[1])
            
    return(mergeresult)

intervals = [[1,3],[6,9]]
newInterval = [2,5]

print(insertIntervals(intervals, newInterval))