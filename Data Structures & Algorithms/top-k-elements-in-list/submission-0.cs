public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> map = new Dictionary<int, int>();
        List<int> temp = new List<int>();
        for(int i=0; i<nums.Length; i++)
        {
            if(!map.ContainsKey(nums[i]))
                map.Add(nums[i], 1);
            else
                map[nums[i]]++;
        }

        List<int>[] bucket = new List<int>[nums.Length + 1]; 
        foreach(var (key, val) in map)
        {
            if(bucket[val] == null)
                bucket[val] = new List<int>();

            bucket[val].Add(key);
        }

        for(int i=bucket.Length-1; i>=0; i--)
        {
            if(bucket[i] == null)
                continue;
            foreach(var num in bucket[i]){
                temp.Add(num);
                k--;
                if(k==0)
                    return temp.ToArray();
            }
        }

        return temp.ToArray();
    }
}
