'''
Given an integer array sorted in ascending order and a target value, return the indexes of any pair of numbers whose sum equals the target.

- The input array is sorted in ascending order.
- If no valid pair exists, return an empty array [].

Example 1:
Input: numbers = [1,2,3,4,6], target = 6
Output: [1,3]
Explanation: The sum of 2 and 4 is 6. Therefore, index1 = 1, index2 = 3. We return [1, 3].  

Example 2:
Input: numbers = [2,5,9,11], target = 11
Output: []
Explanation: The sum of 2 and 9 is 11. However, there is no such pair in the array. Therefore, we return an empty array [].
'''

def sorted_pair_sum(nums: list, target: int):
    l = 0
    r = len(nums) - 1

    while l < r:
        sum = nums[l] + nums[r]
        if sum == target:
            return [l,r]
        elif sum < target:
            l += 1
        else: 
            r -= 1
    
    return []

if __name__ == "__main__":
    print(sorted_pair_sum([1,2,3,4,6], 6)) # [1,3]
    print(sorted_pair_sum([2,5,9,11], 11)) # []