public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> set = new HashSet<int>();
        int ans = 0;

        foreach(var num in nums)
            set.Add(num);
        
        foreach(var num in nums)
        {
            if(!set.Contains(num-1))
            {
                int n = num, count = 1;
                while(set.Contains(n+1))
                {
                    count++;
                    n++;
                }
                ans = Int32.Max(ans, count);
            }
        }

        return ans;
    }
}
