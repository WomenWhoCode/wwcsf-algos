/*
344. Reverse String (https://leetcode.com/problems/reverse-string/)

Write a function that reverses a string. The input string is given
as an array of characters char[].

Do not allocate extra space for another array, you must do this by
modifying the input array in-place with O(1) extra memory.

You may assume all the characters consist of printable ascii characters.

Example 1:
	Input: ["h","e","l","l","o"]
	Output: ["o","l","l","e","h"]


Solution:
	1. Set two pointers, left and right
	2. For each iteration,
		Swap left and right characters
		Move them towards the center
	3. Repeat 2 until both pointers meet

	For example,
		["h","e","l","l","o"]
		  ^               ^
		left			right

		["o","e","l","l","h"]
			^       ^
		   left	  right
*/
package reversestring

func reverseString(s []byte) {
	var left, right = 0, len(s) - 1

	for left < right {
		s[left], s[right] = s[right], s[left]
		left++
		right--
	}
}
