public class Solution {
    public int Trap(int[] height) {
        int n = height.Length, ans = 0;
        int[] rightMax = new int[n];
        int max = n-1;
        for(int i=n-2; i>=0; i--)
        {
            if(height[i] == height[max])
            {
                rightMax[i] = max;
                max = i;
            }
            else if(height[i] < height[max])
                rightMax[i] = max;
            else
            {
                max = i;
            }
        }
        int leftMax = 0;
        for(int i=0; i<n; i++)
        {
            if(rightMax[i] == 0)
                rightMax[i] = -1;
            // Console.Write(rightMax[i] + " ");
        }
        // Console.WriteLine();
        for(int i=1; i<n; i++)
        {
            if(height[i] < height[leftMax] && rightMax[i] != -1 && height[i] < height[rightMax[i]])
            {
                int trappedWater = Math.Min(height[leftMax], height[rightMax[i]]) - height[i];
                // Console.WriteLine("TrapperWater: "+ trappedWater + " rightMax:" + height[rightMax[i]] + " leftMax: " + height[leftMax]+" i: "+i);
                ans += trappedWater;
            }

            else if(height[leftMax] <= height[i])
                leftMax = i;
        }
        //1,1,2,1,1
        return ans;
    }
}
