from typing import List

class Solution:
    def removeElement(self, nums: List[int], val: int) -> int:
        l:int = 0
        for i in range(len(nums)):
            if nums[i] != val:
                nums[l] = nums[i] 
                l +=1
        return l  