public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> res = new Dictionary <string, List<string>>();
        foreach (var s in strs){
            int[] count = new int[26]; // a ... z
            foreach (char c in s){
                count[c - 'a']++;
            }
            // converts count array to a string
            string key = string.Join(",", count);  // [1,0,1,0,...,0] → "1,0,1,0,...,0".
            if (!res.ContainsKey(key)){
                res[key] = new List<string>();
            }
            res[key].Add(s);
        }
        return res.Values.ToList<List<string>>(); 


        
    }
}
