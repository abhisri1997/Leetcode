public class Solution {
   public int rev(int num) {
        int rev_num = 0;
        while(num > 0) 
        {
            rev_num = rev_num * 10 + num % 10;
            num /= 10;
        }
        return rev_num;
    }
    public bool SumOfNumberAndReverse(int num) {
        if(num == 0) return true;
        for(int i = 0; i < num; i++)
        {
          int reverse = rev(i);
          if(reverse + i == num) return true;
        }
        return false;
    }
}