public class Solution {
    public int MaxArea(int[] heights) {

        var l = 0;
        var r = heights.Length - 1;
        var output = 0;

        while(l < r)
        {
            var width = r - l;
            var height = Math.Min(heights[l], heights[r]);

            var area = width * height;

            if(area > output)
                output = area;

            if(heights[l] < heights[r])
                l++;
            else
                r--;
        }

        return output;
    }
}
