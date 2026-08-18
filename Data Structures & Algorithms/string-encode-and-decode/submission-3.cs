public class Solution {

    public string Encode(IList<string> strs) {
        var encoded = string.Empty;
        var dict = new Dictionary<string, List<int>>();

        for(int i = 0; i < strs.Count;i++)
        {
            var str = strs[i];
            if(!dict.ContainsKey(str))
                dict.Add(str, new List<int>(){i});
            else
                dict[str].Add(i);
        }

        var sb = new StringBuilder(strs.Count.ToString());
        sb.AppendLine();

        foreach(var key in dict.Keys)
        {
            sb.Append(key);
            sb.AppendLine();
            foreach(var index in dict[key])
            {
                sb.Append(index).Append(',');
            }
            sb.AppendLine();
        }

        return sb.ToString();
    }

    public List<string> Decode(string s) {

        var stringReader = new System.IO.StringReader(s);
        var wordCount = int.Parse(stringReader.ReadLine());
        var result = new List<string>(new string[wordCount]);
        while((stringReader.ReadLine()) is string word)
        {
            var indicesString = stringReader.ReadLine();
            var numbers = indicesString.Split(',');
            foreach(var n in numbers)
            {
                if(!int.TryParse(n.Trim(), out int index))
                    continue;
                result[index] = word;
            }
        }
        
        return result;
   }
}
