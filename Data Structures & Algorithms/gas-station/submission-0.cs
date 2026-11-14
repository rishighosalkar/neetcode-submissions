public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) {
        int n = gas.Length;
        int totalGas = 0, totalCost = 0;
        for(int i=0; i<n; i++)
        {
            totalGas += gas[i];
            totalCost += cost[i];
        }

        if(totalGas < totalCost)
            return -1;

        int res = 0, tank = 0;

        for(int i=0; i<n; i++)
        {
            tank += (gas[i] - cost[i]);

            if(tank < 0)
            {
                tank = 0;
                res = i+1;
            }
        }

        return res;
    }
}
