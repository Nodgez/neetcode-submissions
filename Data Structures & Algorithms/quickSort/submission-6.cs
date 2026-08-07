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
    public List<Pair> QuickSort(List<Pair> pairs) {

        QuickSorter(pairs, 0, pairs.Count - 1);
        return pairs;
    }

    public void QuickSorter(List<Pair> pairs, int start, int end)
    {
        if(end - start + 1  <= 1)
            return;
        Pair pivot = pairs[end];
        int left = start;

        for(int i = start;i < end;i++)
        {
            if(pairs[i].Key < pivot.Key)
            {
                Pair temp = pairs[left];
                pairs[left] = pairs[i];
                pairs[i] = temp;
                left++;
            }
        }

        pairs[end] = pairs[left];
        pairs[left] = pivot;

        QuickSorter(pairs, start, left - 1);
        QuickSorter(pairs, left + 1, end);
    }
}
