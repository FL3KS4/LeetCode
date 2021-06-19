public class Solution {
    public bool ArrayStringsAreEqual(string[] word1, string[] word2) 
    {
        StringBuilder sb = new StringBuilder();
        StringBuilder sb2 = new StringBuilder();
            
            foreach(string s in word1)
            {
                sb.Append(s);
            }
        
            foreach(string s in word2)
            {
                sb2.Append(s);
            }
        
        if(sb.ToString() == sb2.ToString())
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
