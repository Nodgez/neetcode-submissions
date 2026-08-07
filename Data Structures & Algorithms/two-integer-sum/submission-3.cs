public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        if(nums.Length == 2)
            return new int[2]{0,1};        

        var set = new HashSet<int>();

        for(int i = 0; i < nums.Length;i++)
        {
            var n = nums[i];
            var diff = target - n;

            if(set.Contains(diff))
            {
                var j = Array.IndexOf(nums, diff);
                return new int[2]{j, i};
            }

            set.Add(n);
        }

        return new int[0];
    }
}
