public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        
        var dict = new Dictionary<string, List<String>>();

        foreach(var str in strs)
        {
            var sortedString = str.ToCharArray();
            Array.Sort(sortedString);
            var key = new string(sortedString);

            if(!dict.ContainsKey(key))
            {
                dict.Add(key, new List<string>(){str});
                continue;
            }

            dict[key].Add(str);
        }

        return dict.Values.ToList();
    }
}
