public class Solution {
    public List<List<string>> GroupAnagrams(string[] inputStrings) {
        // This will look like this:
        // {
        //     "1,0,1,0,...,0": ["eat", "tea", "ate"],
        //     "0,0,0,0,...,1": ["tan", "nat"],
        //     "1,1,0,0,...,0": ["bat"]
        // }
        Dictionary<string, List<string>> res = new Dictionary <string, List<string>>();
        foreach (var currentString in inputStrings){
            int[] letterFrequency = new int[26]; // a ... z
            foreach (char c in currentString){
                letterFrequency[c - 'a']++;
            }
            // converts letterFrequency array to a string
            string key = string.Join(",", letterFrequency);  // converts array to string since keys need to be immutable in hashmaps[1,0,1,0,...,0] → "1,0,1,0,...,0".
            if (!res.ContainsKey(key)){
                res[key] = new List<string>();
            }
            res[key].Add(currentString);
        }
        return res.Values.ToList<List<string>>(); 


        
    }
}
