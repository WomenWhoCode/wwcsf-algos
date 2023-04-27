"""
Link to LeetCode: https://leetcode.com/problems/combination-sum/

Problem Description from LeetCode:
Given an array of distinct integers candidates and a target integer target, return a list of all unique combinations of candidates where the chosen numbers sum to target. You may return the combinations in any order.

The same number may be chosen from candidates an unlimited number of times. Two combinations are unique if the frequency of at least one of the chosen numbers is different.

It is guaranteed that the number of unique combinations that sum up to target is less than 150 combinations for the given input.
"""
from typing import List

class CombSum:
    def combinations(self, arr: List[int], target: int, path: List[int], final: List[List[int]]):
        # When we get to target 0, a path is found and therefore, we append the current path to the final list of valid paths
        if target == 0:
            final.append(path.copy()) # path.copy() is required here because in python when the value of path changes later it also changes contents of final variable. Therefore, copy() is used to prevent that by making sure we only copy the contents of the path variable in final variable instead of pointing to the memory location of path.
            return

        # When the path is no longer valid
        if target < 0:
            return
        
        for i in range(0, len(arr)):
            if arr[i] > target: # if any element is greater than target we can ignore those
                continue
            # Add each element to path
            path.append(arr[i])
            # explore paths
            val = self.combinations(arr[i:], target - arr[i], path, final)
            # pop the last element so that we can explore next path 
            path.pop()
           
# To run the above function locally
solution = CombSum()
# Here, the values of `candidates`, `target` are example values set to test the function locally. To run this code in different example, you can change the values of these variables.
candidates = [ 2, 3, 6, 7 ]
target = 7
path = []
final = []
solution.combinations(candidates, target, path, final) 
print(final) # The result will be reflected in `final` variable as we append each path to `final` variable in the above function 
                
