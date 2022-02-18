public class Solution {
    public string DefangIPaddr(string address) {
        String newAddress = "";
        for (int i = 0; i < address.Length; i++)
        {
            if(address[i] != '.') {
                newAddress = newAddress + address[i];
            } else {
                newAddress = newAddress + "[.]";
            }
        }
        return newAddress;
    }
}