public class Solution {
    public int LengthOfLastWord(string s) {
        if (s.Length==0) return 0;
        string[] words= s.Split(" ");  //Split into array
        for (int k=words.Length-1;k>=0;k--) //Inverse Array, if find last word, quit immediately
        {
            
            if (words[k].Length>0){
                return words[k].Length; 
            }
        }
        
        return 0;
    }
}