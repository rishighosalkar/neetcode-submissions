public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        
        Array.Sort(nums);
        // Dictionary<List<int>, int> dict = new Dictionary<List<int>, int>();
        int n=nums.Length;
        List<List<int>> ls = new List<List<int>>();
        //-4,-1,-1,0,1,2
        for(int i=0; i<n; i++)
        {
            if(i>0 && nums[i] ==  nums[i-1])
                continue;
            
            int curr = nums[i];
            int start = i+1, end = n-1;
            while(start < end)
            {
                if(nums[start]+nums[end] < -1*curr)
                    start++;
                else if(nums[start]+nums[end] > -1*curr)
                    end--;
                else
                {
                    ls.Add(new List<int>{curr, nums[start], nums[end]});
                    start++;
                    end--;
                    while(start < n && nums[start] == nums[start-1])
                        start++;
                    while(end >= 0 && nums[end] == nums[end+1])
                        end--;
                }
                
            }
        }

        return ls;
    }
}
