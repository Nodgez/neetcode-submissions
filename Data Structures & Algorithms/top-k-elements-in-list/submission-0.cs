public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> counts = new Dictionary<int,int>();

        foreach(var n in nums)
        {
            if(!counts.ContainsKey(n))
            {
                counts.Add(n,0);
            }
            counts[n]++;
        }

        List<int[]> arr = counts.Select(entry => new int[] {entry.Value, entry.Key}).ToList();
        arr.Sort((kvp1, kvp2) => kvp2[0].CompareTo(kvp1[0]));
        var result = new int[k];
        for(var i = 0; i < k; i++)
        {
            result[i] = arr[i][1];
        }

        return result;
    }
}
