public class Solution {
    public bool IsPalindrome(string s) {
        var str = s.Replace(" ", "").ToLower();
        Regex rgx = new Regex("[^a-zA-Z0-9]");
        str = rgx.Replace(str, "");

        int l = 0;
        int r = str.Length - 1;

        while(l < r)
        {
            if(str[l] != str[r])
                return false;
            l++;
            r--;
        }

        return true;
    }
}
