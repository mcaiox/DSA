public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int l = 0;
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] != val) {
                nums[l] = nums[i];
                l+=1;
            }
        }
        return l;
    }
}

// Example usage:
// int[] nums = new int[] {3,2,2,3};
// int val = 3;
// Remove all instances of val from nums in-place
// Return the number of elements remaining in nums
// The first k elements of nums will contain the elements not equal to val 