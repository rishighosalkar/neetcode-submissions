public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int product = 1, countZero = 0;
        int[] ans = new int[nums.Length];
        foreach(var num in nums)
        {
            if(num != 0)
                product = product * num;
            else
                countZero++;
        }

        if(countZero > 1)
            return ans;
        
        for(int i=0; i<nums.Length; i++)
        {
            if(nums[i] == 0)
                ans[i] = product;
            else if(nums[i] != 0 && countZero == 0)
                ans[i] = product/nums[i];
        }

        return ans;
    }
}
