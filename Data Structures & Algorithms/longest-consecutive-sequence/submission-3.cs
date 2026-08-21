public class Solution {
    public int LongestConsecutive(int[] nums) {

        if(nums.Length == 0)
            return 0;

        Array.Sort(nums);

        var set = new HashSet<int>(nums);
        var prev = int.MinValue;
        var span = 0;
        var count = 0;

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
