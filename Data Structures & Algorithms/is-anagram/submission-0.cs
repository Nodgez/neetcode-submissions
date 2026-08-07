public class Solution {
    public bool IsAnagram(string s, string t) {

        if(s.Length != t.Length)
            return false;

        var orderedS = string.Concat(s.OrderBy(c => c));
        var orderedT = string.Concat(t.OrderBy(c => c));

        var stringLength = orderedS.Length;

        for(int i = 0; i < stringLength;i++)
        {
            if(orderedS[i] != orderedT[i])
                return false;
        }

        return true;
    }
}
