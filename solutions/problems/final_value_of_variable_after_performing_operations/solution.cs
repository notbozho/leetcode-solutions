public class Solution {
    public int FinalValueAfterOperations(string[] operations) {
        int x = 0;
        foreach(String operation in operations) {
            switch(operation.ToLower()) {
                case "x++":
                case "++x":
                    x++;
                    break;
                case "x--":
                case "--x":
                    x--;
                    break;
            }
        }
        return x;
    }
}