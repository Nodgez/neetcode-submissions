public class Solution {
    public int[] ProductExceptSelf(int[] nums) {

        var result = new int[nums.Length];
        var prefix = new int[nums.Length];
        var postfix = new int[nums.Length];

        for(int i = 0; i < nums.Length;i++)
        {
            var n = nums[i];
            prefix[i] = n * (i < 1 ? 1 : prefix[i - 1]);
        }

        for(int i = nums.Length - 1; i > -1;i--)
        {
            var n = nums[i];
            postfix[i] = n * (i >= nums.Length - 1 ? 1 : postfix[i + 1]);
        }

        for(int i = 0; i < result.Length;i++)
        {
            var pre = i == 0 ? 1 : prefix[i - 1];
            var post = i == result.Length -1 ? 1 : postfix[i + 1];

            result[i] = post * pre;
        }

        return result;
    }
}
