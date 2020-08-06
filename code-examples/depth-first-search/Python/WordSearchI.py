#https://leetcode.com/problems/word-search/
#Given a 2D board and a word, find if the word exists in the grid.

# The word can be constructed from letters of sequentially adjacent cell, 
# where "adjacent" cells are those horizontally or vertically neighboring.
#  The same letter cell may not be used more than once.

def checkword(board, row,column, string):
            
        if len(string) == 0:
            word = 'Found'
            return word
        
        #Increment/Decrement the row and column 
        dfs = [(0,1), (0,-1), (1,0),(-1,0)]
        
        if (row >= len(board) or row < 0 or column >= len(board[0]) or column < 0 or board[row][column] != string[0]):
            return

        # Change the current checking entry to '@'
        #so that it is not traversed again.
        temp = board[row][column]
        board[row][column] = '@'  
        for i, j in dfs:               
                if (checkword(board, row+i, column+j,string[1:])):
                  return True
        board[row][column] = temp 
        return False
         
        


def wordsearch(board, rows,columns):

    for row in range(rows):
        for column in range(columns):
            
            #Check only if the current entry starts with the string first letter
            if board[row][column] == word[0]:
                if (checkword(board, row,column, word)):
                    return True
                    
    print('False')

board = [["A","B","C","E"],["S","F","C","S"],["A","D","E","E"]]
word = "ABCB"
rows = len(board)
columns = len(board[0])
print(wordsearch(board, rows, columns))