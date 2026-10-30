public class Solution {
    public int FindMin(int[] nums) {
        int l=0, h=nums.Length-1, min = int.MaxValue;

        if(nums[l] < nums[h])
            return nums[l];

        while(l<=h)
        {
            int mid = (l+h)/2;

            if(nums[l] <= nums[mid])
            {
                min = Math.Min(min, nums[l]);
                l = mid+1;
            }
            else
            {
                min = Math.Min(min, nums[mid]);    
                h = mid-1;
            }
        }

        return min;
    }
}
