// Definition for a pair.
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
    public List<Pair> MergeSort(List<Pair> pairs) {

        Console.WriteLine("\n");
        foreach(var p in pairs)
        {
            Console.WriteLine(string.Format("{0} : {1}", p.Key, p.Value));
        }

        if(pairs.Count <= 1)
            return pairs;

        int m = pairs.Count / 2;
        List<Pair> left = pairs.GetRange(0, m);
        List<Pair> right = pairs.GetRange(m,pairs.Count-m);

        MergeSort(left);
        MergeSort(right);

        int i = 0;
        int j = 0;

        while(i < left.Count && j < right.Count)
        {
            if(left[i].Key <= right[j].Key)
            {
                pairs[i + j] = left[i];
                i++;
            }
            else
            {
                pairs[i + j] = right[j];
                j++;
            }
        }

        while (i < left.Count) {
            pairs[i + j] = left[i];
            i++;
        }
        while (j < right.Count) {
            pairs[i + j] = right[j];
            j++;
        }

        foreach(var p in pairs)
        {
            Console.WriteLine(string.Format("{0} : {1}", p.Key, p.Value));
        }
        Console.WriteLine("\n");

        return pairs;
    }

}
