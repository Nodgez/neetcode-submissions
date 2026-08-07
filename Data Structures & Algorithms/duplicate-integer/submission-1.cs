public class Solution {
    public bool hasDuplicate(int[] nums) {

        if(nums.Length < 1)
            return false;

        var valueSet = new HashSet<int>();

        for(int i = 0;i < nums.Length;i++)
        {
            var val = nums[i];
            if(valueSet.Contains(val))
                return true;

            valueSet.Add(val);
        }

        return false;
    }
}