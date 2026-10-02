public class Solution {
    public int CharacterReplacement(string s, int k) {
        
        Dictionary<char, int> frequencies = new ();
        char high = s[0];
        int output = 0;
        int l = 0;

        if(s.Length == 1)
            return s.Length;

        if(k >= s.Length)
            return s.Length;

        for(int r = 0; r < s.Length;r++)
        {
            char curr = s[r];
            if(!frequencies.ContainsKey(curr))
                frequencies.Add(curr, 0);

            frequencies[curr]++;

            if(frequencies[high] < frequencies[curr])
                high = curr;
            
            int window_L = r - l + 1;
            if(window_L - frequencies[high] > k)
            {
                frequencies[s[l]]--;
                l++;
            }
        }

        return s.Length - l;
    }
}
