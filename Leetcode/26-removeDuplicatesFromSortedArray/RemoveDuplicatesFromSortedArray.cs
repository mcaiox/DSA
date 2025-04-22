public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int l = 1;
        for (int r = 1; r < nums.Length; r++) {
            if (nums[r] != nums[r-1]) {
                nums[l] = nums[r];
                l++;
            }
        }
        return l;
    }
}

// Example usage:
// int[] nums = new int[] {0,0,1,1,1,2,2,3,3,4};
// The array is sorted in ascending order
// Remove duplicates in-place such that each unique element appears only once
// The relative order of elements should be kept the same
// Return the number of unique elements in nums (k)
// The first k elements of nums will contain the unique elements in their original order 