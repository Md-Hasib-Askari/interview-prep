'''
Given an integer array, return all triplets [a, b, c] such that:
a + b + c == 0

Rules:
- Do not return duplicate triplets.
- Different orderings of the same values count as duplicates.
    - Example: [1, 2, 3] and [2, 3, 1] are the same triplet.
- If no valid triplets exist, return [].
- Triplets in the output can be in any order.

Example 1:
Input: nums = [-1,0,1,2,-1,-4]
Output: [[-1,-1,2],[-1,0,1]]
Explanation: The triplet [-1,0,1] sums to 0. The triplet [-1,-1,2] also sums to 0. Notice that the order of the output and the order of the triplets does not matter.
'''

def triplet_sum(nums: list):
    nums.sort()
    triplets = []

    for i in range(len(nums) - 2):
        if i > 0 and nums[i] == nums[i-1]:
            continue
        
        l = i + 1
        r = len(nums) - 1

        while l < r:
            sum = nums[i] + nums[l] + nums[r]
            if sum == 0:
                triplets.append([nums[i], nums[l], nums[r]])
                l += 1
                r -= 1

                while l < r and nums[l] == nums[l-1]:
                    l += 1
                while l < r and nums[r] == nums[r+1]:
                    r -= 1
            elif sum < 0:
                l += 1
            else:
                r -= 1
    
    return triplets