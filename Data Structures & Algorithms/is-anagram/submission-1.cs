public class Solution {
    public bool IsAnagram(string s, string t) {

        if(s.Length != t.Length)
            return false;

        var orderedS = s.ToCharArray();
        var orderedT = t.ToCharArray();

        Array.Sort(orderedS);
        Array.Sort(orderedT);

        var stringLength = orderedS.Length;

        for(int i = 0; i < stringLength;i++)
        {
            if(orderedS[i] != orderedT[i])
                return false;
        }

        return true;
    }
}
