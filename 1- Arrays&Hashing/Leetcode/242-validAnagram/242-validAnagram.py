def isAnagram(self, s: str, t: str) -> bool:
    # Quick optimisation: if strings have different lengths, they can't be anagrams
    if len(s) != len(t):
        return False
    
    # Create two hash maps to count character frequencies
    countS, countT = {}, {}

    # Iterate through both strings simultaneously
    for i in range(len(s)):
        # For both strings: count the frequency of each character at position i
        # This builds frequency maps showing how many times each character appears
        countS[s[i]] = 1 + countS.get(s[i], 0)
        countT[t[i]] = 1 + countT.get(t[i], 0)
    
    # Compare the two frequency maps
    # If they're equal, both strings have the same characters with same frequencies = anagram
    # If they're different, the strings are not anagrams
    return countS == countT