public class Solution {
    public int BinarySearch(int[] nums, int l, int h, int target)
    {
        while(l<=h)
        {
            int mid = (l+h)/2;
            if(nums[mid] == target)
            {
                return mid;
            }
            else if(nums[mid] > target)
                h = mid-1;
            else
                l = mid+1;
        }

        return -1;
    }

    public int PeakElement(int[] nums)
    {
        int l = 1, h = nums.Length-2;
        int n=nums.Length;
        if(n == 1 || nums[0] > nums[1])
            return 0;
        // if(nums[n-1] > nums[n-2])
        //     return n-1;
        while(l<=h)
        {
            int mid = (l+h)/2;
            if(nums[mid-1] < nums[mid] && nums[mid] > nums[mid+1])
            {
                return mid;
            }
            if(nums[mid-1] < nums[mid] && nums[mid] < nums[mid+1])
                l = mid+1;
            else
                h = mid-1;
        }

        return -1;
    }
    public int Search(int[] nums, int target) {
        int peak = PeakElement(nums);
        // Console.WriteLine(peak);
        if(peak == -1)
            return BinarySearch(nums, 0, nums.Length-1, target);
        if(target >= nums[0] && target <= nums[peak])
            return BinarySearch(nums, 0, peak, target);
        else
            return BinarySearch(nums, peak+1, nums.Length-1, target);
        
        return -1;
    }
}
