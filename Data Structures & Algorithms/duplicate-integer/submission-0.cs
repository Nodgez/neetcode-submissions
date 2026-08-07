public class Solution {
    public bool hasDuplicate(int[] nums) {
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