public class Solution {
    public int MaxSubArray(int[] nums) {
        int start=0, end=0, sum=0, maxSum = int.MinValue;

        while(end<nums.Length)
        {
            sum += nums[end];
            maxSum = Math.Max(maxSum, sum);
            while(sum <= 0 && start <= end)
            {
                sum -= nums[start];
                start++;
            }
            end++;
        }

        return maxSum;

    }
}
