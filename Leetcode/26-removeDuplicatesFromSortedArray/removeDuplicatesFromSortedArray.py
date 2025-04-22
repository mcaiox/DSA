class Solution:
    def removeDuplicates(self, nums: list[int]) -> int:
        l = 1
        for r in range(1, len(nums)):
            if nums[r] != nums[r-1]:
                nums[l] = nums[r]
                l+=1
        return l

# nums = [0,0,1,1,1,2,2,3,3,4]
# Nums is an array that is sorted in ascending order [1,2,3,4]
# Remove duplicates in-place sucht that each unique element appears only once
# The relative order of elements should be kept the same 
# Return the number of unique elements in nums, consider this be k 
# Change the array nums such that the first k elements of nums contain the unique elements in the order they were present in nums initial
# return k

# Example:
# Input: nums = [0,0,1,1,1,2,2,3,3,4]
