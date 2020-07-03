//https://leetcode.com/problems/find-lucky-integer-in-an-array/

//Approach 1: O(n)
class Solution {
public:
    int findLucky(vector<int>& arr) {
        map<int, int> freq;
        vector<int> lucky;
        int i, n=arr.size();
        for(i=0; i<n; i++){
            if(freq.find(arr[i])==freq.end())
                freq.insert(make_pair(arr[i],1));
            else
                freq.find(arr[i])->second++;
        }
        map<int, int>::iterator itr; 
        for (itr = freq.begin(); itr != freq.end(); ++itr){
            if(itr->first==itr->second)
                lucky.push_back(itr->first);
        }
        if(lucky.size()==0)
            return -1;
        return *max_element(lucky.begin(), lucky.end());
    }
};

//Approach 2: (With sorting) O(nlogn)
class Solution {
public:
    int findLucky(vector<int>& arr) {
         sort(begin(arr), end(arr), greater<int>());
        int count=1, i, n=arr.size();
        for (i = 1; i < n; i++) {
        if (arr[i] == arr[i - 1])
            count++;
        else {
            if (arr[i - 1] == count)
                return count;
            count = 1;
        }
    }
    return arr.back() == count ? count : - 1;
    
    }
};
