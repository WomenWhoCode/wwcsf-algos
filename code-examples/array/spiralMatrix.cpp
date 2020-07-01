/*
https://leetcode.com/problems/spiral-matrix/

Runtime: 0 ms, faster than 100.00% of C++ online submissions for Spiral Matrix.
Memory Usage: 6.9 MB, less than 83.90% of C++ online submissions for Spiral Matrix.
*/
class Solution {
public:
    vector<int> spiralOrder(vector<vector<int>>& matrix) {
        vector<int> spiral;
        if(matrix.size()==0)
            return spiral;
        int i=0, j=0, rowMin=0, colMin=0, m= matrix.size(), n=matrix.front().size();
        char direction='r';
        // r=right, d=down, l=left, u=up
        while(i<m && j<n && i>=rowMin && j>=colMin){
            spiral.push_back(matrix[i][j]);
            if(direction=='r'){
                if(j== n-1 ){
                    direction='d';
                    i++;
                }    
                else
                    j++;
            }
            else if(direction=='d'){
                if(j==n-1 && i==m-1 ){
                    direction='l';
                    j--;
                }    
                else
                    i++;
            }
            else if(direction=='l'){
                if(j==colMin){
                    direction='u';
                    rowMin+=1;
                    m--; n--;
                    i--;
                        
                }
                else
                    j--;
            }
            else{
                if(i==rowMin){
                    direction='r';
                    colMin+=1;
                    j++;
                }
                else
                    i--;
            }
                
        }
        return spiral;
    }
};
