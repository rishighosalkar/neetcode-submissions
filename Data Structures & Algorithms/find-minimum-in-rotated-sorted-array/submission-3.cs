public class Solution {
    public int FindPeak(int[] nums)
    {
        int n = nums.Length;
        if(n == 1 || nums[0] > nums[1])
            return 0;
        if(nums[n-1] < nums[n-2])
            return n-1;
        
        int l=1, h=n-2;
        while(l<=h)
        {
            int mid = (l+h)/2;
            if(nums[mid] > nums[mid-1] && nums[mid] > nums[mid+1])
                return mid;
            else if(nums[mid] > nums[l] && nums[mid-1] < nums[mid] && nums[mid] < nums[mid+1])
                l = mid+1;
            else 
                h = mid-1;
        }

        return -1;
    }
    public int FindMin(int[] nums) {
        if(nums.Length == 1)
            return nums[0];
        
        int peak = FindPeak(nums);
        Console.WriteLine(peak);
        if(peak == -1)
            return nums[0];
        else if(peak == nums.Length-1)
            return nums[nums.Length-1];
        else
            return nums[peak+1];
    }
}
