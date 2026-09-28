public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] ans = new int[nums.Length];
        int n=nums.Length;
        Array.Fill(ans, 1);
        for(int i=1; i<n; i++)
            ans[i] = nums[i-1]*ans[i-1];

        int right=1;
        for(int i=n-1; i>=0; i--)
        {
            ans[i] *= right;
            right *= nums[i];
        }

        return ans;
    }
}
