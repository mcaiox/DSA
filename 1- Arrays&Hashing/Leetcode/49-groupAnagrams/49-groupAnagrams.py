from collections import defaultdict
from typing import List

class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
        res = defaultdict(list)
        for s in strs: # iterate through each string in the list
            count = [0] * 26 # creates a list of 26 zeros
            for c in s: # iterate through each character in the string
                count[ord(c) - ord('a')] += 1 # ord() is a built-in function that returns the Unicode code point for a given character.
            res[tuple(count)].append(s) # Makes the count list as a key and appends which strings match
        return list(res.values()) # Returns the values of the dictionary as a list of lists
    # res = {
    # (1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0): ["act", "cat"],
    # (0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0): ["pots", "tops", "stop"],
    # (1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0): ["hat"]
    # }