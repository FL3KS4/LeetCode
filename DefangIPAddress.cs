public class Solution {
    public string DefangIPaddr(string address) {
        
        StringBuilder newAddress = new StringBuilder();
        foreach(char c in address)
        {
           
           if(c == '.')
           {
               newAddress.Append("[.]");
           }
           else
           {
               newAddress.Append(c);
           }
        }
        
        return newAddress.ToString();
    }
}