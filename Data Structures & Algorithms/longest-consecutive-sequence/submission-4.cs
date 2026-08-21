public class Solution {
    public int LongestConsecutive(int[] nums) {

        if(nums.Length == 0)
            return 0;

        var set = new HashSet<int>(nums);
        var span = 0;

        foreach(var n in set)
        {
            if(!set.Contains(n - 1))
            {
                var curr = n;
                var len = 1;

                while(set.Contains(curr + 1))
                {
                    curr++;
                    len++;
                }

                span = Math.Max(len, span);
            }
            
        }
        return span;        
    }
}
