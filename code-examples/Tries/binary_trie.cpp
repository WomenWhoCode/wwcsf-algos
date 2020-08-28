/*
    implementation of a trie that can maintain information of binary strings and supports insert, remove and search methods on the bitstrings.
*/


#include<iostream>
using namespace std;
int len=8;
class node{
    public:
        char c;
        int dollar;
        node* right;
        node* left;
        node* centre;
        node(char r){
            dollar=0;
            c=r;
            centre=NULL;
            right=NULL;
            left=NULL;
        }
};
class trie{
    public:
        node* root;
        trie(){
            root=new node('2');
        }
        int search(string s){
            node* temp=root;
            int i=0;
            while(i<len){
                if(s[i]=='0'){
                    if(temp->left==NULL){
                        return 0;
                    }
                    else{
                        temp=temp->left;
                    }
                }
                else{
                    if(temp->right==NULL){
                        return 0;
                    }
                    else{
                        temp=temp->right;
                    }
                }
                i++;
            }
            if(temp->centre->c=='$'){
                temp->dollar++;
                return 1;
            }
            else{
                return 0;
            }
        }
        
        int insert(string s){
            if(search(s)==1){
                return 0;
                }
            int k=len-1;
            while(k>=0){
                node* temp=root;
                int i=k;
                while(i<len){
                    if(s[i]=='0'){
                        if(temp->left==NULL){
                            temp->left=new node('0');
                            temp=temp->left;
                            temp->dollar++;
                        }
                        else{
                            temp=temp->left;
                            temp->dollar++;
                        }
                    }
                    else{
                        if(temp->right==NULL){
                            temp->right=new node('1');
                            temp=temp->right;
                            temp->dollar++;
                        }
                        else{
                            temp=temp->right;
                            temp->dollar++;
                        }
                    }
                i++;
                }
            temp->centre=new node('$');
            k--;  
            }
            return 1;
        }
        int remove(string s){
            if(search(s)==0){
                return 0;
            }
            int k=len-1;
            while(k>=0){
                node* temp=root;
                int i=k;
                while(i<len){
                    if(s[i]=='0'){
                        if(temp->left==NULL){
                            temp->left=new node('0');
                            temp=temp->left;
                            temp->dollar--;
                        }
                        else{
                            temp=temp->left;
                            temp->dollar--;
                        }
                    }
                    else{
                        if(temp->right==NULL){
                            temp->right=new node('1');
                            temp=temp->right;
                            temp->dollar--;
                        }
                        else{
                            temp=temp->right;
                            temp->dollar--;
                        }
                    }
                i++;
                }
            temp->centre=new node('#');
            k--;  
            }
            return 1;
        }
};

int main(){
    trie suff;
    cout<<suff.insert("10101010")<<'\n';
    cout<<suff.insert("11001111")<<'\n';
    cout<<suff.insert("10110010")<<'\n';
    cout<<suff.search("10101010")<<'\n';
    cout<<suff.remove("10101010")<<'\n';
    cout<<suff.search("10101010")<<'\n';
    cout<<suff.insert("10101010")<<'\n';

}
