public class Solution {
    public bool IsValid(string s) {

        if(s.Length % 2 == 1)
            return false;

        var map = new Dictionary<char, char>()
        {
            {']', '['},
            {'}', '{'},
            {')', '('}
        };

        var stack = new Stack<char>();

        foreach(var c in s)
        {
            if(!map.ContainsKey(c))
                stack.Push(c);
            else if(stack.Count > 0)
            {
                var p = stack.Pop();
                if(map[c] != p)
                    return false;
            }
            else
                return false;
        }

        return stack.Count == 0;
    }
}
