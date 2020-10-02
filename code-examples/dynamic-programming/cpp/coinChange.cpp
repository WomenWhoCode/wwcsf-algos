//https://leetcode.com/problems/coin-change/

class Solution {
public:
    int coinChange(vector<int>& coins, int amount) {
        vector<int> dp(amount+1, amount+1);
        sort(coins.begin(), coins.end());
        dp[0]=0;
        for(int i=0; i<=amount; i++){
            for(int j=0; j<coins.size(); j++){
                if(coins[j] <= i)
                    dp[i]=min(dp[i], dp[i-coins[j]]+1);
                else
                    break;
            }
        }
        return dp[amount]>amount ? -1: dp[amount];
    }
};
