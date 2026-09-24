public class Solution {
    public int FindMin(int[] nums) {
        int l = 0;
        int r = nums.Length -1;
        int mid = (r - l) / 2;
        int result = 0;


        if(nums.Length == 1)
            return nums[0];

        if(nums.Length == 2)
        return Math.Min(nums[0], nums[1]);

        while(mid > l && mid < r)
        {
            if(nums[r] < nums[mid])
            {
                l = mid;
                mid += (r - l) / 2;
                result = Math.Min(nums[mid], nums[r]);
            }
            else
            {
                r = mid;
                mid -= (r - l) / 2;
                result = Math.Min(nums[mid], nums[l]);
            }
        }
        
        return result;
    }
}
