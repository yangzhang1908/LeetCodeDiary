public class Solution {
    public int LengthOfLongestSubstring(string s) {
        // start end pointer => 
        // if contains, del all until the contained element.
        // get length.
        
        int end = 0;
        int maxLength = 0;
        List<char> tempSub = new List<char>();
        
        // IDictionary<int, char> tempDict = new Dictionary<int, char>();
        for(; end < s.Length; end++){
        
            if(tempSub.Contains(s[end])){
                tempSub.RemoveRange(0,tempSub.IndexOf(s[end]) + 1);
            }
            tempSub.Add(s[end]);
            maxLength  = maxLength > tempSub.Count?  maxLength : tempSub.Count; 
        }
        return maxLength;
    }
}
