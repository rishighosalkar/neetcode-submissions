public class Solution {
    public int MaxArea(int[] heights) {
        int start = 0, end = heights.Length-1, ans = 0;

        while(start < end)
        {
            int minHeight = Math.Min(heights[start], heights[end]);
            ans = Math.Max(ans, minHeight * (end-start));
            if(heights[start] < heights[end])
                start++;
            else if(heights[start] > heights[end])
                end--;
            else
            {
                start++;
                end--;
            }
        }

        return ans;
    }
}
