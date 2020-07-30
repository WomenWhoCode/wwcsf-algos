//https://leetcode.com/problems/longest-increasing-subsequence/
// DP O(n^2) solution

class Solution {
public:
    int lengthOfLIS(vector<int>& nums) {
        if(nums.size()<=1)
            return nums.size();
        int i, j=0,n=nums.size();
        int l[n];
        for(i=0;i<n;i++)
            l[i]=1;
        for(i=1;i<n;i++){
            while(j<i){
                if(nums[j]<nums[i])
                    l[i]=max(l[i],(l[j]+1));
                j++;
            }
            j=0;
        }
        return *max_element(l, l+n);
    }
};
