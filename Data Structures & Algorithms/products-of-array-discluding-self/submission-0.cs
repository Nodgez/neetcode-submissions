public class Solution {
    public int[] ProductExceptSelf(int[] nums) {

        int zeroCount = 0;
        int zeroIndex = -1;
        int product = 1;
        var l = nums.Length;
        for(int i = 0; i < l;i++)
        {
            if(nums[i] == 0)
            {
                zeroCount++;
                zeroIndex = i;
            }
            else
            {
                product *= nums[i];
            }
        }

        int[] result = new int[l];
        Array.Fill(result, 0);

        if(zeroCount < 1)
        {
            for(int j = 0; j < l;j++)
            {
                result[j] = product / nums[j];
            }
        }

        else if(zeroCount == 1)
        {
            result[zeroIndex] = product;
        }

        return result;
    }
}
