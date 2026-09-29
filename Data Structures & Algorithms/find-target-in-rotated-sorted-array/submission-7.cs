public class Solution {
    public int Search(int[] nums, int target) {

        int l = 0;
        int r = nums.Length - 1;

        while(l <= r)
        {
            var mid = l + (r - l) / 2;

            if(nums[mid] == target)
                return mid;

            //Searching to the left of the array
            if(nums[l] <= nums[mid])
            {
                //search right
                if(target > nums[mid] || target < nums[l])
                    l = mid + 1;
                else
                    r = mid - 1;
            }

            else //search the right hand side
            {
                if(target < nums[mid] || target > nums[r])
                    r = mid - 1;
                else
                    l = mid + 1;
            }

        }
        return -1;
    }
}
