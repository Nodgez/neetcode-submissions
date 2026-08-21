public class Solution {
    public int LongestConsecutive(int[] nums) {

        Array.Sort(nums);

        var set = new SortedSet<int>(nums);
        var prev = int.MinValue;
        var span = 0;
        var count = 0;

        if(nums.Length == 0)
            return 0;
            
        foreach(var n in set)
        {
            if(n - prev != 1)
            {
                span = Math.Max(span, count);
                count = 0;
            }

            count++;
            prev = n;
        }

        span = Math.Max(span, count);
        return span;        
    }
}
