public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder sb = new StringBuilder();
        foreach(var s in strs)
        {
            sb.Append(s.Length).Append('#').Append(s);
        }

        return sb.ToString();
    }

    public List<string> Decode(string s) {
        
        List<string> result = new List<string>();
        var tally = 0;
        for(int i = 0; i < s.Length;i++)
        {
            var c = s[i];
            if(c != '#')
            {
                tally++;
            }
            else
            {
                var letterCount = Convert.ToInt16(s.Substring(i - tally, tally));
                var word = s.Substring(i + 1, letterCount);
                result.Add(word);
                i += letterCount;
                tally = 0;
            }

        }
    return result;
   }
}
