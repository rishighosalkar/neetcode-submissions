public class Solution {
    public bool DFS(List<List<int>> adj, int src, ref int[] vis)
    {
        if(vis[src] == 1)
            return false;
        
        if(vis[src] == 2)
            return true;

        vis[src] = 1;
        foreach(var u in adj[src])
        {
            if(!DFS(adj, u, ref vis))
                return false;
        }

        vis[src] = 2;
        return true;
    }
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        List<List<int>> adj = new List<List<int>> (numCourses+1);
        
        for (int i = 0; i <= numCourses; i++)
            adj.Add(new List<int>());

        for(int i=0; i<prerequisites.Length; i++)
            adj[prerequisites[i][0]].Add(prerequisites[i][1]);

        // for(int i=0; i<adj.Count; i++)
        // {
        //     Console.Write(i+"->");
        //     foreach(var lis in adj[i])
        //     {
        //         Console.Write($"{lis}->");
        //     }
        //     Console.WriteLine();
        // }

        int[] vis = new int[numCourses+1];
        
        for(int i=0; i<=numCourses; i++)
        {
            if(!DFS(adj, i, ref vis))
                return false;
        }

        return true;
    }
}
