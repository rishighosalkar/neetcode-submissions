public class Solution {
    public int FindDuplicate(int[] nums) {
        int start = nums[0], end = nums[nums[0]];

        while (start != end)
        {
            start = nums[start];
            end = nums[nums[end]];
        }

        start = 0;
        while (start != end)
        {
            start = nums[start];
            end = nums[end];
        }
        
        return start; 
    }
}