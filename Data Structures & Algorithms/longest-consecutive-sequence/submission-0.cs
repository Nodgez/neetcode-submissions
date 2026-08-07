public class Solution {
    public int LongestConsecutive(int[] nums) {
        if(nums.Length == 0)
        {
            return 0;
        }

        Array.Sort(nums);

        int result = 0, curr = nums[0], streak = 0, i = 0;

        while(i < nums.Length){
            if(curr != nums[i])
            {
                streak = 0;
                curr = nums[i];
            }

            while(i < nums.Length && curr == nums[i]){
                i++;
            }

            streak++;
            curr++;
            result = Math.Max(result, streak);
        }

        return result;
    }
}
