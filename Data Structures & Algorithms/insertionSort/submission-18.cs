// Definition for a pair
// public class Pair {
//     public int Key;
//     public string Value;
//
//     public Pair(int key, string value) {
//         Key = key;
//         Value = value;
//     }
// }
public class Solution {
    public List<List<Pair>> InsertionSort(List<Pair> pairs) {
        int n = pairs.Count;
        List<List<Pair>> result = new List<List<Pair>>();
        for(int i = 0; i < pairs.Count;i++)
        {
            int j = i - 1;
            while(j >= 0 && pairs[j + 1].Key < pairs[j].Key)
            {
                var temp = pairs[j];
                pairs[j]  = pairs[j + 1];
                pairs[j + 1] = temp;
                j--;
            }
            List<Pair> cloneList = new List<Pair>(pairs);
            result.Add(cloneList);
        }

        foreach(var kvp in result)
        {
            foreach(var l in kvp)
                Console.WriteLine(l.Key);

            Console.WriteLine("\n");
        }
        return result;
    }
}
