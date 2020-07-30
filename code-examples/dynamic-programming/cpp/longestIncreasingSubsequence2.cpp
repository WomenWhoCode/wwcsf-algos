// https://leetcode.com/problems/longest-increasing-subsequence/

//METHOD 2 DP+binary search (using lower bound) O(nlogn)

class Solution {
public:
    int lengthOfLIS(vector<int>& nums) {
        if(nums.size()<=1)
            return nums.size();
        int i, j=0,n=nums.size(), pos;
        vector<int> v;
        v.push_back(nums[0]);
        for(i=1; i<n; i++){
            if(nums[i]>v.back())
                v.push_back(nums[i]);
            else{
                pos= lower_bound(v.begin(), v.end(), nums[i])- v.begin();
                v[pos]=nums[i];
            }
        }
        return v.size();
    }
};
