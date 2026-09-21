public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {

        var output = new List<List<int>>();
        Array.Sort(nums);

        //-[i] = [j] + [k]
        for(int i = 0; i < nums.Length; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1])
                continue;

            var target = -nums[i];
            var j = i + 1;
            var k = nums.Length - 1;

            while(j < k)
            {
                var e = nums[j] + nums[k];

                if(e == target)
                {
                    output.Add(new List<int>{nums[i], nums[j], nums[k]});
                    j++;
                    k--;
                    while (j < k && nums[j] == nums[j - 1]) j++;
                    while (j < k && nums[k] == nums[k + 1]) k--;
                }
                else if(e < target)
                    j++;
                else
                    k--;
            }

        }
        return output;
    }
}