public class Solution {
    public bool LemonadeChange(int[] bills) {
      int fiveBills = 0;
            int tenBills = 0;

            for (int i = 0; i < bills.Length; i++)
            {
                if (bills[i] == 5)
                {
                    fiveBills++;
                } else if (bills[i] == 10 && fiveBills > 0)
                {
                    fiveBills--;
                    tenBills++;
                } else if (bills[i] == 20 && (fiveBills > 0 && tenBills > 0)) {
                    fiveBills--;
                    tenBills--;
                }
                else if (bills[i] == 20 && (fiveBills > 2))
                {
                    fiveBills -= 3;
                } else {
                    return false;
                }

            }
            return true;
    }
}