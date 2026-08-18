public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        int[] result = new int[k];
        Dictionary<int, int> buckets = new();

        for(int i = 0; i < nums.Length;i++)
        {
            var n = nums[i];
            if(!buckets.ContainsKey(n))
                buckets.Add(n, 1);
            else
                buckets[n]++;
        }

        var pq = new PriorityQueue<int, int>();

        foreach(var key in buckets.Keys)
        {
            var freq = buckets[key];
            pq.Enqueue(key, -freq);
        }

        for(int i = 0; i < k;i++)
        {
            result[i] = pq.Dequeue();
        }

        return result;
   }
}
