public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> groups = new Dictionary<string, List<string>>();
        foreach(var s in strs)
        {
            var charArray = s.ToCharArray();
            Array.Sort(charArray);
            var sorted = new string(charArray);
            if(!groups.ContainsKey(sorted))
            {
                groups.Add(sorted, new List<string>());
            }
            groups[sorted].Add(s);
        }

        return groups.Values.ToList<List<string>>();
    }
}
