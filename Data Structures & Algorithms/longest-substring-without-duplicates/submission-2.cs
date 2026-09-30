public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<char> set = new ();
        int l = 0;
        int r = 0;
        int result = 0;

        while(r < s.Length)
        {
            if(!set.Contains(s[r]))
            {
                set.Add(s[r]);
                r++;
            }
            else
            {
                set.Remove(s[l]);
                l++;
            }

            result = Math.Max(result, r - l);
        }

        return Math.Max(result, r - l);
    }
}
