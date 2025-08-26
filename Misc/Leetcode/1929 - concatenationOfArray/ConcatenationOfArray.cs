public class Solution {
    public int[] GetConcatenation(int[] nums) {

        int[] ans = new int[(2 * nums.Length)];
        Array.Copy(nums, ans, nums.Length);

        for (int i =0; i< nums.Length; i++){
            ans[nums.Length + i] = nums[i];
        }
        return ans;

        
    }
}