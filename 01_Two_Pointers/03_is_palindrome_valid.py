'''
Given a string s, determine if it is a palindrome, considering only alphanumeric characters and ignoring cases.

A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and removing all non-alphanumeric characters, it reads the same forward and backward.

Example 1:
Input: s = "A man, a plan, a canal: Panama"
Output: true
Explanation: "amanaplanacanalpanama" is a palindrome.

Example 2:
Input: s = "race a car"
Output: false
Explanation: "raceacar" is not a palindrome.
'''

def is_palindrome(s: str):
    l = 0
    n = len(s) - 1
    r = n

    while l < r:
        while l < r and not s[l].isalnum():
            l += 1
        while r > l and not s[r].isalnum():
            r -= 1
        
        if l >= r:
            break
        
        if s[l].lower() != s[r].lower():
            return False

        l += 1
        r -= 1
    
    return True