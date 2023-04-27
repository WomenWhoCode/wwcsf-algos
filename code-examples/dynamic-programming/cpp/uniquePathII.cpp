//https://leetcode.com/problems/unique-paths-ii/

class Solution {
public:
    int uniquePathsWithObstacles(vector<vector<int>>& obstacleGrid) {
        if (obstacleGrid[0][0] == 1) {
            return 0;
        }
        int n= obstacleGrid.size();
        int m= obstacleGrid[0].size();
        vector<vector<int> > dp(n,vector<int> (m, 0));
        int  i, j;
        dp[0][0]=1;
        for(i=1; i<n; i++){
            if(obstacleGrid[i][0]==0)
                  dp[i][0]=dp[i-1][0];
        }
        for(i=1; i<m; i++){
            if(obstacleGrid[0][i]==0)
                  dp[0][i]=dp[0][i-1];
        }
        for(i=1; i<n; i++){
            for(j=1; j<m; j++){
                if(obstacleGrid[i][j]==0){
                        dp[i][j]= dp[i-1][j] + dp[i][j-1];
                }
            }
        }
        return dp[n-1][m-1];
    }
};

