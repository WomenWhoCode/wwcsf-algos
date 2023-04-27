# https://leetcode.com/problems/corporate-flight-bookings/
# 
# There are n flights, and they are labeled from 1 to n.
# We have a list of flight bookings.  
# The i-th booking bookings[i] = [i, j, k] means that we booked 
# k seats from flights labeled i to j inclusive.

# Return an array answer of length n, representing the number of seats booked on each flight in order of their label.
#  Should fill the output table in ranges to avoid time limit exceeded

n = 5
bookings = [[1,2,10],[2,3,20],[2,5,25]]
output = [0] * (n+1)

#Fill the output table in range so that we can eliminate time limit exceeded error.
for x, y, z in bookings:
    
    output[x-1] += z    
    output[y] -= z
    
for i in range(1,n):    
    output[i] += output[i-1]  
      
print(output[:n])